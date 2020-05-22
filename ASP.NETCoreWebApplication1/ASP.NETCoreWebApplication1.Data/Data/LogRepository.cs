using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;

namespace ASP.NETCoreWebApplication1.Data.Data
{
    public class LogRepository : Repository<Log, ApplicationDbContext>, ILogRepository
    {
        public LogRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
