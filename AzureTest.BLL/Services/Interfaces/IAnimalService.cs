using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IAnimalService
    {
        Task<Animal> CreateAnimal(Animal animal);
        Task<ICollection<Animal>> GetAllAsync(
            AnimalsFilter filter = null,
            PaginationFilter pagination = null);
        Task UpdateAnimal(int id, Animal animal);
        Task<Animal> GetAsync(int id);
        Task RemoveAnimal(Animal animal);
    }
}
