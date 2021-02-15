using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IAnimalTypeService
    {
        Task CreateAnimalType(AnimalType animal);
        Task<ICollection<AnimalType>> GetAllAsync(PaginationFilter paginationFilter);
        Task<AnimalType> GetAsync(int id);
        Task RemoveAnimalType(AnimalType animal);
        Task UpdateAnimalType(int id,AnimalType animal);
    }
}