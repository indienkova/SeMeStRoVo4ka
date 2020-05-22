using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Data;
using ASP.NETCoreWebApplication1.Interfaces;
using ASP.NETCoreWebApplication1.Models;
using ASP.NETCoreWebApplication1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        
        public PostController(IPostRepository postRepository, IUnitOfWork unitOfWork, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            return Json(await _postRepository.Get(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_postRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PostViewModel post)
        {
            var postModel = new Post
            {
                Body = post.Body,
                Category = post.Category,
                Comments = new List<Comment>(),
                Rating = 0,
                Title = post.Title
            };

            await _postRepository.Add(postModel);
            await _unitOfWork.CompleteAsync();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _postRepository.Delete(id);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }
        [HttpPut("Upvote")]
        public IActionResult Upvote(Post post)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == HttpContext.User.Identity.Name);
            if (!post.userVotes.Contains(user))
            {
                post.Rating++;
                post.userVotes.Add(user);
                _context.Update(post);
                _unitOfWork.CompleteAsync();
                return Ok();
            }
            else return Ok();
        }
        
        [HttpPut("downvote")]
        public IActionResult Downvote(Post post)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == HttpContext.User.Identity.Name);
            if (!post.userVotes.Contains(user))
            {
                post.Rating--;
                _context.Update(post);
                _unitOfWork.CompleteAsync();
                return Ok();
            }
            else return Ok();
        }
    }
}