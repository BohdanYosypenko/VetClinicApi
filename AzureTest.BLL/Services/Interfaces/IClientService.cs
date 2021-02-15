using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IClientService
    {
        public Task<Client> AddClient(User user, Client client);
        public Task<ICollection<Client>> GetAllClients();

        public  Task<ICollection<Client>> GetAllClients(
            ClientsFilter filter = null,
            PaginationFilter pagination = null);

        public Task<IEnumerable<string>> GetAllClientsEmails();
        public Task<Client> GetClient(int id);
        public Task<bool> PutClient(User user, Client client);
        public Task<bool> DeleteClient(int id);
    }
}
