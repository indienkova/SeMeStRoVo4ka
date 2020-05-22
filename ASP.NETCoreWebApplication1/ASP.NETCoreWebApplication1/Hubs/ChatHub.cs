using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Core.Models;

namespace ASP.NETCoreWebApplication1.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(MessageModel message) =>
           await Clients.All.SendAsync("receiveMessage", message);
        
    }
}
