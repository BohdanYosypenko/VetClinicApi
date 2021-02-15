using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class PositionService : IPositionService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public PositionService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<Position> AddPositionAsync(Position position)
        {
            Position createdPosition = new Position();

            createdPosition.PositionName = position.PositionName;
            createdPosition.Salary = position.Salary;

            _repositoryWrapper.PositionRepository.Add(createdPosition);
            await _repositoryWrapper.SaveAsync();
            return createdPosition;
        }

        public async Task<Position> GetPositionByIdAsync(int positionId)
        {            
           return await _repositoryWrapper.PositionRepository.GetFirstOrDefaultAsync(p => p.Id == positionId);                      
        }

        public async Task<ICollection<Position>> GetPositionAsync(
            PaginationFilter pagination = null)
        {
            if (pagination != null)
            {
                return await _repositoryWrapper.PositionRepository.GetAsync(                    
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }

            return await _repositoryWrapper.PositionRepository.GetAsync();
        }
              
        public async Task<bool> RemovePositionAsync(int id)
        {
            var position = await _repositoryWrapper.PositionRepository.GetFirstOrDefaultAsync(p => p.Id == id);
            if (position != null)
            {
                _repositoryWrapper.PositionRepository.Remove(position);
                await _repositoryWrapper.SaveAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> UpdatePositionAsync(Position position, int id)
        {
            if (position == null)
                return false;

            if (await this.IsAnyPositionAsync(id))
            {
                position.Id = id;
                _repositoryWrapper.PositionRepository.Update(position);
                await _repositoryWrapper.SaveAsync();
                return true;
            }

            return false;            
        }
        public Task<bool> IsAnyPositionAsync(int id)
        {
            return _repositoryWrapper.PositionRepository.IsAnyAsync(p=>p.Id==id);
        }
    }
}
