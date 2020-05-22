using ASP.NETCoreWebApplication1.Interfaces;
using ASP.NETCoreWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebApplication1.Data
{
    public class MessageRepository : Repository<MessageModel, ApplicationDbContext>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
