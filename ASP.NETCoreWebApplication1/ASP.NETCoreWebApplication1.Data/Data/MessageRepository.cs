using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;

namespace ASP.NETCoreWebApplication1.Data.Data
{
    public class MessageRepository : Repository<MessageModel, ApplicationDbContext>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
