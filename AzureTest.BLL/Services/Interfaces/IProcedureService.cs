using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IProcedureService
    {
        public Task AddProcedure(Procedure procedure);
        public Task<ICollection<Procedure>> GetAllProcedures();
        public Task<Procedure> GetProcedure(int id);
        public Task<bool> PutProcedure(int id, Procedure procedure);
        public Task<bool> DeleteProcedure(int id);
    }
}
