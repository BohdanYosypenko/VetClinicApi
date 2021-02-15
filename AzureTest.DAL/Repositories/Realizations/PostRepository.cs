using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.DAL.Repositories.Realizations
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(ApplicationContext context) : base(context) { }
    }
}
