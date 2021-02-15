using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IServiceService
    {
        Task<ICollection<Service>> GetAllServicesAsync();

        Task<Service> GetServiceByIdAsync(int id);

        Task<Service> AddAsync(Service service);

        Task<bool> UpdateAsync(int id, Service service);

        Task<bool> RemoveAsync(int serviceId);
    }
}
