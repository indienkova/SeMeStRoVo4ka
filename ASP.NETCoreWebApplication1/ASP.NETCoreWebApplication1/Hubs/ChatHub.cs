using ASP.NETCoreWebApplication1.Data;
using ASP.NETCoreWebApplication1.Interfaces;
using ASP.NETCoreWebApplication1.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebApplication1.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(MessageModel message) =>
           await Clients.All.SendAsync("receiveMessage", message);
        
    }
}
