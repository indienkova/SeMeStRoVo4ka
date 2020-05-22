using ASP.NETCoreWebApplication1.Interfaces;
using ASP.NETCoreWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebApplication1.Data
{
    public class FilesRepository : Repository<Files, ApplicationDbContext>, IFilesRepository
    {
        public FilesRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
