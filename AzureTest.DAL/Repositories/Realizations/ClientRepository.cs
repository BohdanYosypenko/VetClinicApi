using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.DAL.Repositories.Realizations
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(ApplicationContext context) : base(context) { }
    }
}