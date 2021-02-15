using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.DAL.Repositories.Realizations
{
    public class ProcedureRepository : RepositoryBase<Procedure>, IProcedureRepository
    {
        public ProcedureRepository(ApplicationContext context) : base(context) { }
    }
}