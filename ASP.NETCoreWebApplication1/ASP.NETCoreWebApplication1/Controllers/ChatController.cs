using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Data;
using ASP.NETCoreWebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ASP.NETCoreWebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;
        public ChatController(UserManager<ApplicationUser> userManager,ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Find(userId);
            var messages = _context.Messages.Include(m=>m.Sender).ToList();
            foreach (var message in messages)
            {
                message.isMine = message.Sender == user;
            }
            return Ok(messages);
        }
        
        [HttpPost("send")]
        public async Task<IActionResult> Send(MessageModel message)
        {
            var m = new MessageModel {UserName = HttpContext.User.Identity.Name,Text = message.Text};
            var user = await _userManager.GetUserAsync(User);
            m.Sender = user;
            await _context.Messages.AddAsync(m);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}