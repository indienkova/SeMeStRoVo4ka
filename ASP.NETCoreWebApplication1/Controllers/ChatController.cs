using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Interfaces;
using ASP.NETCoreWebApplication1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        private IMessageRepository _messageRepository;
        private IUnitOfWork _unitOfWork;
        private UserManager<ApplicationUser> _userManager;
        public ChatController(IMessageRepository messageRepository, IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _messageRepository = messageRepository;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_messageRepository.GetAll());
        }

        public async Task<IActionResult> Create(MessageModel message)
        {
            message.UserName = User.Identity.Name;
            var sender = await _userManager.GetUserAsync(User);
            message.UserId = sender.Id;
            await _messageRepository.Add(message);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }
    }
}