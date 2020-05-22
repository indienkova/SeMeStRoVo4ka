using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;

namespace ASP.NETCoreWebApplication1.Data.Data
{
    public class FilesRepository : Repository<Files, ApplicationDbContext>, IFilesRepository
    {
        public FilesRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
