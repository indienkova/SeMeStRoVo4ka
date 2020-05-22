
﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Core.ViewModels;
using ASP.NETCoreWebApplication1.Data.Data;
using ASP.NETCoreWebApplication1.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PostController(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
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

        [HttpPost("create")]
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
            return Ok();
        }
        
        [HttpPut("downvote")]
        public IActionResult Downvote(Post post)
        {
            return Ok();
        }
    }
}