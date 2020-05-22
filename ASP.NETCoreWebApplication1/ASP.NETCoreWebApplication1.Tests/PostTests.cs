using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Controllers;
using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;
using Moq;
using NUnit.Framework;
using Newtonsoft.Json;

namespace ASP.NETCoreWebApplication1.Tests
{
    public class PostTests
    {
        [Test]
        public void GetAllPostsTest()
        {
            var mock = new Mock<IPostRepository>();
            mock.Setup(repo=>repo.GetAll()).Returns(GetTestPosts());
            var posts =  mock.Object.GetAll();
            Assert.AreEqual(3, posts.Count());
        }

        [Test]
        public void GetPostById()
        {
            var mock = new Mock<IPostRepository>();
            mock.Setup(repo=>repo.GetAll()).Returns(GetTestPosts());
            var post = mock.Object.GetAll().FirstOrDefault(p => p.PostId == 1);
            Assert.AreEqual(1, post.PostId);
        }
        
        [Test]
        public async Task AddPostTest()
        {
            var mock = new Mock<IPostRepository>();
            mock.Setup(repo=>repo.GetAll()).Returns(GetTestPosts());
            await  mock.Object.Add(new Post());
            Assert.AreEqual(GetTestPosts().Count(), mock.Object.GetAll().Count());
        }
        
        [Test]
        public void DeletePostTest()
        {
            var mock = new Mock<IPostRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestPosts());
            mock.Object.Delete(3);
            var posts = mock.Object.GetAll().Take(2);
            Assert.AreEqual(2, posts.Count());
        }
        
        private Post GetPost()
        {
            return  new Post() {PostId = 1};
        }
        private List<Post> GetTestPosts()
        {
            return new List<Post>()
            {
                new Post() {PostId = 1},
                new Post() {PostId = 2},
                new Post() {PostId = 3}
            };
        }
    }
}