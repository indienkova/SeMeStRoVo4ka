using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;

namespace ASP.NETCoreWebApplication1.Data.Data
{
    public class PostRepository : Repository<Post, ApplicationDbContext>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
