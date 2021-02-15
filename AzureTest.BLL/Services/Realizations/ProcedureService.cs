using System.Collections.Generic;
using VetClinic.DAL.Repositories.Interfaces;
using VetClinic.DAL.Entities;
using System.Threading.Tasks;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class ProcedureService : IProcedureService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
              
        public ProcedureService(IRepositoryWrapper repositoryWrapper)
        {           
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task AddProcedure(Procedure procedure)
        {
              _repositoryWrapper.ProcedureRepository.Add(procedure);
               await _repositoryWrapper.SaveAsync();
        }

        public async Task<ICollection<Procedure>> GetAllProcedures()
        {
            return await _repositoryWrapper.ProcedureRepository.GetAsync();
        }

        public async Task<Procedure> GetProcedure(int id)
        {
            return await _repositoryWrapper.ProcedureRepository.GetFirstOrDefaultAsync(
                filter: p => p.Id == id
                );
        }

        public async Task<bool> PutProcedure(int id, Procedure procedure)
        {
            var foundProcedure = await _repositoryWrapper.ProcedureRepository.GetFirstOrDefaultAsync(filter: p => p.Id == id);
            if (foundProcedure == null) return false;
            foundProcedure.Description = procedure.Description;
            foundProcedure.Price = procedure.Price;
            foundProcedure.ProcedureName = procedure.ProcedureName;
            _repositoryWrapper.ProcedureRepository.Update(foundProcedure);
            await _repositoryWrapper.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteProcedure(int id)
        {
            var foundProcedure = await _repositoryWrapper.ProcedureRepository.GetFirstOrDefaultAsync(filter: p => p.Id == id);
            if (foundProcedure == null)
                return false;
            _repositoryWrapper.ProcedureRepository.Remove(foundProcedure);
            await _repositoryWrapper.SaveAsync();
            return true;
        }
    }
}
