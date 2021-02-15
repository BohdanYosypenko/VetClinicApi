using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Helpers;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class ClientService : IClientService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IUserService _userService;
        public ClientService(IRepositoryWrapper repositoryWrapper, IUserService userService)
        {
            _repositoryWrapper = repositoryWrapper;
            _userService = userService;
        }

        public async Task<Client> AddClient(User user, Client client)
        {
            IdentityRole role = new IdentityRole { Name = "client" };
            var (res, id) = await _userService.CreateUserAsync(user, role);
            string userId;
            if (res)
            {
                userId = id;
                client = new Client { UserId = userId };
                _repositoryWrapper.ClientRepository.Add(client);
                await _repositoryWrapper.SaveAsync();
            }
            return client;
        }

        public async Task<ICollection<Client>> GetAllClients()
        {
            return await _repositoryWrapper.ClientRepository.GetAsync(include: c => c.Include(c => c.User));
        }

        public async Task<IEnumerable<string>> GetAllClientsEmails()
        {
            IEnumerable<string> emails;
            var clients = await GetAllClients();
            emails = clients.Select(client => client.User.Email);
            return emails;
        }

        public async Task<ICollection<Client>> GetAllClients(
            ClientsFilter filter = null,
            PaginationFilter pagination = null)
        {
            if (pagination != null && filter != null)
            {
                return await _repositoryWrapper.ClientRepository.GetAsync(filter: Filter(filter), include: Include(),
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }

            if (filter != null)
            {
                return await _repositoryWrapper.ClientRepository.GetAsync(filter: Filter(filter), include: Include());
            }

            if (pagination != null)
            {
                return await _repositoryWrapper.ClientRepository.GetAsync(include: Include(),
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }
            return await _repositoryWrapper.ClientRepository.GetAsync(include: Include());
        }

        public async Task<Client> GetClient(int id)
        {
            return await _repositoryWrapper.ClientRepository.GetFirstOrDefaultAsync(
                filter: c => c.Id == id,
                include: c => c.Include(c => c.User)
                );
        }

        public async Task<bool> PutClient(User user, Client client)
        {
            IdentityRole role = new IdentityRole { Name = "client" };
            var res = await _userService.UpdateUserAsync(client.UserId, user, role);
            await _repositoryWrapper.SaveAsync();
            return res;
        }

        public async Task<bool> DeleteClient(int id)
        {
            var foundClient = await _repositoryWrapper.ClientRepository.GetFirstOrDefaultAsync(filter: c => c.Id == id);
            if (foundClient == null)
                return false;
            var userDeleted = await _userService.DeleteUserAsync(foundClient.UserId);
            if (!userDeleted) return false;
            _repositoryWrapper.ClientRepository.Remove(foundClient);
            await _repositoryWrapper.SaveAsync();
            return true;
        }

        private static Func<IQueryable<Client>, IIncludableQueryable<Client, object>> Include()
        {
            return app => app
                .Include(c => c.User);
                
        }

        private static Expression<Func<Client, bool>> Filter(ClientsFilter filter)
        {
            var expressionsList = new List<Expression<Func<Client, bool>>>();

            if (filter.UserId != null)
            {
                Expression<Func<Client, bool>> idFilter = a => a.UserId == filter.UserId;
                expressionsList.Add(idFilter);
            }

            if (filter.UserName != null)
            {
                Expression<Func<Client, bool>> usernameFilter = a => a.User.UserName == filter.UserName;
                expressionsList.Add(usernameFilter);
            }

            if (filter.IsDeleted != null)
            {
                Expression<Func<Client, bool>> userFilter = a => a.User.IsDeleted == filter.IsDeleted.Value;
                expressionsList.Add(userFilter);
            }

            if (filter.IsDeleted == null)
            {
                Expression<Func<Client, bool>> userFilter = a => !a.User.IsDeleted;
                expressionsList.Add(userFilter);
            }

            Expression<Func<Client, bool>> expression = animal => true;

            foreach (var exp in expressionsList)
            {
                expression = expression.AndAlso(exp);
            }

            return expression;
        }

       

    }
}
