﻿using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;

namespace ASP.NETCoreWebApplication1.Data.Data
{
    public class UserRepository : Repository<ApplicationUser, ApplicationDbContext>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
