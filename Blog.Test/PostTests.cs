using System.Collections.Generic;
using Blog.Controllers;
using Blog.Data;
using Blog.Models;
using Moq;
using NUnit.Framework;
using System.Linq;
using Blog.Interfaces;

namespace Blog.Test
{
    public class PostsTests
    {
        [Test]
        public void GetCategoryTest()
        {
            
        }
            
        private List<Post> GetTestPosts()
        {
            var posts = new List<Post>
                {
                    new Post(),
                    new Post(),
                    new Post(),
                    new Post()
                };
            return posts;
        }
    }
}