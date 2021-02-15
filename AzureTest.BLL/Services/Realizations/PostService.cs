using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class PostService : IPostService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public PostService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<Post> CreatePost(Post post)
        {
            _repositoryWrapper.PostRepository.Add(post);
            await _repositoryWrapper.SaveAsync();

            var createdPost = await GetAsync(post.Id);

            return createdPost;
        }

        public async Task<ICollection<Post>> GetAllAsync(
            PaginationFilter pagination = null)
        {
            if (pagination != null)
            {
                return await _repositoryWrapper.PostRepository.GetAsync(
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }

            return await _repositoryWrapper.PostRepository.GetAsync();
        }

        public async Task<Post> GetAsync(int id)
        {
            return (await _repositoryWrapper.PostRepository.GetAsync(x => x.Id == id)).FirstOrDefault();
        }

        public async Task UpdatePost(int id, Post post)
        {
            var postToUpdate = (await _repositoryWrapper.PostRepository.GetAsync(x => x.Id == id)).FirstOrDefault();

            //update fields
            postToUpdate.Title = post.Title;
            postToUpdate.Subtitle = post.Subtitle;
            postToUpdate.MainText = post.MainText;
            postToUpdate.Photo = post.Photo;

            _repositoryWrapper.PostRepository.Update(postToUpdate);
            await _repositoryWrapper.SaveAsync();
        }

        public async Task RemovePost(Post post)
        {
            _repositoryWrapper.PostRepository.Remove(post);
            await _repositoryWrapper.SaveAsync();
        }
    }
}
