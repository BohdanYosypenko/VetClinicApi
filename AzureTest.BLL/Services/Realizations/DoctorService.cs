using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
    public class DoctorService : IDoctorService
    {
        private readonly IUserService _userService;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        public DoctorService(IRepositoryWrapper repositoryWrapper, IUserService userService, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _repositoryWrapper = repositoryWrapper;
            _userService = userService;
        }

        public async Task<ICollection<Doctor>> GetDoctorAsync(
            DoctorsFilter filter = null,
            PaginationFilter pagination = null)
        {

            if (pagination != null && filter != null)
            {
                return await _repositoryWrapper.DoctorRepository.GetAsync(filter: Filter(filter),
                    include: c => c.Include(i => i.User)
                    .Include(d => d.Position),
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }

            if (filter != null)
            {
                return await _repositoryWrapper.DoctorRepository.GetAsync(filter: Filter(filter),
                    include: c => c.Include(i => i.User)
                    .Include(d => d.Position));
            }

            if (pagination != null)
            {
                return await _repositoryWrapper.DoctorRepository.GetAsync(
                    include: c => c.Include(i => i.User)
                    .Include(d => d.Position),
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }

            var doctors = await _repositoryWrapper.DoctorRepository.GetAsync(
                include: c => c.Include(i => i.User)
                .Include(d => d.Position));
            return doctors;
        }

        public async Task<Doctor> GetDoctorByIdAsync(int doctorId)
        {
            Doctor doctor = await _repositoryWrapper.DoctorRepository.GetFirstOrDefaultAsync(
                filter: d => d.Id == doctorId,
                include: d => d.Include(c => c.User)
                .Include(d => d.Position));

            if (doctor == null)
                return null;

            return doctor;
        }

        public async Task<Doctor> AddDoctorAsync(Doctor doctor, User user)
        {
            var role = await this.DoctorRoleExistAsync();

            var (sucssess, userId) = await _userService.CreateUserAsync(user, role);
            if (sucssess)
            {
                doctor.User = await _userService.GetUser(userId);
                _repositoryWrapper.DoctorRepository.Add(doctor);
                await _repositoryWrapper.SaveAsync();
            }

            return await _repositoryWrapper.DoctorRepository.GetFirstOrDefaultAsync(
                filter: d => d.Id == doctor.Id,
                include: d => d.Include(c => c.User)
                .Include(d => d.Position));
        }

        public async Task<bool> RemoveDoctorAsync(int doctorId)
        {
            var doctor = await _repositoryWrapper.DoctorRepository
                .GetFirstOrDefaultAsync(d => d.Id == doctorId);
            if (doctor != null)
            {
                _repositoryWrapper.DoctorRepository.Remove(doctor);
                await _userService.DeleteUserAsync(doctor.UserId);

                await _repositoryWrapper.SaveAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> UpdateDoctorAsync(Doctor inputDoctor, User inputUser, int doctorId)
        {
            var role = await this.DoctorRoleExistAsync();

            if (inputDoctor == null)
                return false;

            if (inputUser == null)
                return false;

            else
            {
                inputDoctor.Id = doctorId;

                await _userService.UpdateUserAsync(inputDoctor.UserId, inputUser, role);
                _repositoryWrapper.DoctorRepository.Update(inputDoctor);

                await _repositoryWrapper.SaveAsync();
                return true;
            }
        }

        public Task<bool> IsAnyDoctorAsync(int id)
        {
            return _repositoryWrapper.DoctorRepository.IsAnyAsync(d => d.Id == id);
        }

        public async Task<int> GetTotalCount(DoctorsFilter filter = null)
        {
            return await _repositoryWrapper.DoctorRepository.CountAsync(Filter(filter));
        }

        private async Task<IdentityRole> DoctorRoleExistAsync()
        {
            var role = await _roleManager.FindByNameAsync("doctor");
            if (role == null)
            {
                await _roleManager.CreateAsync(
                    new IdentityRole() { Name = "doctor" });
                role = await _roleManager.FindByNameAsync("doctor");
            }
            return role;
        }

        private static Expression<Func<Doctor, bool>> Filter(DoctorsFilter filter)
        {
            var expressionsList = new List<Expression<Func<Doctor, bool>>>();

            if (filter.PositionId != null)
            {
                Expression<Func<Doctor, bool>> positionFilter = a => a.PositionId == filter.PositionId;
                expressionsList.Add(positionFilter);
            }

            if (filter.UserId != null)
            {
                Expression<Func<Doctor, bool>> userFilter = a => a.UserId == filter.UserId;
                expressionsList.Add(userFilter);
            }

            if (filter.IsDeleted != null)
            {
                Expression<Func<Doctor, bool>> userFilter = a => a.User.IsDeleted == filter.IsDeleted.Value;
                expressionsList.Add(userFilter);
            }

            if (filter.IsDeleted == null)
            {
                Expression<Func<Doctor, bool>> userFilter = a => !a.User.IsDeleted;
                expressionsList.Add(userFilter);
            }

            if (filter.Name != null)
            {
                Expression<Func<Doctor, bool>> nameFilter = a => a.User.FirstName.ToUpper().StartsWith(filter.Name.ToUpper())
                || a.User.LastName.ToUpper().StartsWith(filter.Name.ToUpper())
                || (a.User.FirstName.ToUpper() + " " + a.User.LastName.ToUpper()).StartsWith(filter.Name.ToUpper())
                || (a.User.LastName.ToUpper() + " " + a.User.FirstName.ToUpper()).StartsWith(filter.Name.ToUpper());
                expressionsList.Add(nameFilter);
            }

            Expression<Func<Doctor, bool>> expression = doctor => true;

            foreach (var exp in expressionsList)
            {
                expression = expression.AndAlso(exp);
            }

            return expression;
        }

        public async Task<IEnumerable<string>> GetAllDoctorsEmails()
        {
            IEnumerable<string> emails;
            var doctors = await GetDoctorAsync();
            emails = doctors.Select(d => d.User.Email);
            return emails;
        }
    }
}
