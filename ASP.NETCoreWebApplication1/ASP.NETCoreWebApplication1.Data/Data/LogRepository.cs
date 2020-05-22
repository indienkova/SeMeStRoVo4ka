using ASP.NETCoreWebApplication1.Interfaces;
using ASP.NETCoreWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebApplication1.Data
{
    public class LogRepository : Repository<Log, ApplicationDbContext>, ILogRepository
    {
        public LogRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
