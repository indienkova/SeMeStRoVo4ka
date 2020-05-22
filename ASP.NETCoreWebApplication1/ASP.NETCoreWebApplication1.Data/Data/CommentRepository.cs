using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;

namespace ASP.NETCoreWebApplication1.Data.Data
{
    public class CommentRepository : Repository<Comment, ApplicationDbContext>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
