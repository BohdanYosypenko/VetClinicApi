using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IPositionService
    {
        public Task<Position> GetPositionByIdAsync(int positionId);
        public Task<ICollection<Position>> GetPositionAsync(
            PaginationFilter pagination = null);
        public Task<Position> AddPositionAsync(Position position);
        public Task<bool> RemovePositionAsync(int id);
        public Task<bool> UpdatePositionAsync(Position position, int id);
        public Task<bool> IsAnyPositionAsync(int id);
    }
}
