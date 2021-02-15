using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IPostService
    {
        Task<Post> CreatePost(Post post);
        Task<ICollection<Post>> GetAllAsync(PaginationFilter pagination = null);
        Task<Post> GetAsync(int id);
        Task RemovePost(Post post);
        Task UpdatePost(int id, Post post);
    }
}