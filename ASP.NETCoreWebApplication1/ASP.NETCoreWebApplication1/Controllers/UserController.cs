//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ASP.NETCoreWebApplication1.Interfaces;
//using ASP.NETCoreWebApplication1.Models;
//using ASP.NETCoreWebApplication1.ViewModels;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace ASP.NETCoreWebApplication1.Controllers
//{
//    [ApiController]
//    [Route("api/{controller}")]
//    public class UserController : Controller
//    {
//        private readonly IUserRepository _userRepository;
//        private readonly IUnitOfWork _unitOfWork;

//        UserController(IUserRepository userRepository, IUnitOfWork unitOfWork)
//        {
//            _userRepository = userRepository;
//            _unitOfWork = unitOfWork;
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<IActionResult> GetByID(int id)
//        {
//            return Json(await _userRepository.Get(id));
//        }

//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Json(_userRepository.GetAll());
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create([FromBody] CommentViewModel user)
//        {
//            var commentModel = new User
//            {
//                Body = comment.Body,
//                Rating = 0,
//                UserId = comment.UserId,
//                PostId = comment.PostId
//            };

//            await _userRepository.Add(commentModel);
//            await _unitOfWork.CompleteAsync();

//            return Ok();
//        }

//        [HttpDelete]
//        public async Task<IActionResult> Delete(int id)
//        {
//            await _userRepository.Delete(id);
//            await _unitOfWork.CompleteAsync();
//            return Ok();
//        }
//    }
//}