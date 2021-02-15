using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class ServiceService : IServiceService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public ServiceService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<ICollection<Service>> GetAllServicesAsync()
        {
            return await _repositoryWrapper.ServiceRepository.GetAsync();
        }

        public async Task<Service> GetServiceByIdAsync(int id)
        {
            return await _repositoryWrapper.ServiceRepository.GetFirstOrDefaultAsync(
                filter: s => s.Id == id);
        }

        public async Task<Service> AddAsync(Service service)
        {
            _repositoryWrapper.ServiceRepository.Add(service);
            await _repositoryWrapper.SaveAsync();
            return service;
        }

        public async Task<bool> UpdateAsync(int id, Service service)
        {
            var serviceUpdated = await _repositoryWrapper.ServiceRepository.GetFirstOrDefaultAsync(
               filter: s => s.Id == id);

            if (serviceUpdated == null)
            {
                return false;
            }

            serviceUpdated.ServiceName = service.ServiceName;
            serviceUpdated.Description = service.Description;
            serviceUpdated.Appointments = service.Appointments;

            _repositoryWrapper.ServiceRepository.Update(serviceUpdated);
            await _repositoryWrapper.SaveAsync();
            return true;
        }

        public async Task<bool> RemoveAsync(int serviceId)
        {
            var service = await _repositoryWrapper.ServiceRepository.GetFirstOrDefaultAsync(
                filter: s => s.Id == serviceId);

            if(service == null)
            {
                return false;
            }

            _repositoryWrapper.ServiceRepository.Remove(service);
            await _repositoryWrapper.SaveAsync();
            return true;
        }
    }
}
