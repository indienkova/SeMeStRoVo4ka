using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Core.ViewModels;
using ASP.NETCoreWebApplication1.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CommentController(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            return Json(await _commentRepository.Get(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(_commentRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CommentViewModel comment)
        {
            var commentModel = new Comment
            {
                Body = comment.Body,
                Rating = 0,
                UserId = comment.UserId,
                PostId = comment.PostId
            };

            await _commentRepository.Add(commentModel);
            await _unitOfWork.CompleteAsync();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _commentRepository.Delete(id);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }
    }
}