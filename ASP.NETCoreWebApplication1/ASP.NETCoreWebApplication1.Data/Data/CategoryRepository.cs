using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;

namespace ASP.NETCoreWebApplication1.Data.Data
{
    public class CategoryRepository : Repository<Category, ApplicationDbContext>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
