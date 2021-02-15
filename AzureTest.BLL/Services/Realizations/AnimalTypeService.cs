using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class AnimalTypeService : IAnimalTypeService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public AnimalTypeService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task CreateAnimalType(AnimalType animalType)
        {
            _repositoryWrapper.AnimalTypeRepository.Add(animalType);
            await _repositoryWrapper.SaveAsync();
        }

        public async Task<ICollection<AnimalType>> GetAllAsync(
            PaginationFilter pagination = null)
        {
            if (pagination != null)
            {
                return await _repositoryWrapper.AnimalTypeRepository.GetAsync(
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }
            return await _repositoryWrapper.AnimalTypeRepository.GetAsync();
        }

        public async Task<AnimalType> GetAsync(int id)
        {
            return (await _repositoryWrapper.AnimalTypeRepository.GetAsync(x => x.Id == id)).FirstOrDefault();
        }

        public async Task UpdateAnimalType(int id, AnimalType animalType)
        {
            var animalTypeToUpdate = (await _repositoryWrapper.AnimalTypeRepository.GetAsync(x => x.Id == id)).FirstOrDefault();

            //update fields
            animalTypeToUpdate.AnimalTypeName = animalType.AnimalTypeName;

            _repositoryWrapper.AnimalTypeRepository.Update(animalTypeToUpdate);
            await _repositoryWrapper.SaveAsync();
        }

        public async Task RemoveAnimalType(AnimalType animalType)
        {
            _repositoryWrapper.AnimalTypeRepository.Remove(animalType);
            await _repositoryWrapper.SaveAsync();
        }
    }
}
