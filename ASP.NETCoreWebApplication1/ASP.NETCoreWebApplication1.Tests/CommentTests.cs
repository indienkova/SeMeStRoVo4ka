using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreWebApplication1.Core.Models;
using ASP.NETCoreWebApplication1.Data.Interfaces;
using Moq;
using NUnit.Framework;

namespace ASP.NETCoreWebApplication1.Tests
{
    public class CommentTests
    {
        [Test]
        public void GetAllCommentsTest()
        {
            var mock = new Mock<ICommentRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestComments());
            var comments = mock.Object.GetAll();
            Assert.AreEqual(3, comments.Count());
        }

        [Test]
        public void GetCommentById()
        {
            var mock = new Mock<ICommentRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestComments());
            var comment = mock.Object.GetAll().FirstOrDefault(p => p.CommentId == 1);
            Assert.AreEqual(1, comment.CommentId);
        }

        [Test]
        public async Task CreateCommentTest()
        {
            var mock = new Mock<ICommentRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestComments());
            await mock.Object.Add(new Comment());
            Assert.AreEqual(GetTestComments().Count(), mock.Object.GetAll().Count());
        }

        [Test]
        public void DeleteCommentTest()
        {
            var mock = new Mock<ICommentRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestComments());
            mock.Object.Delete(3);
            var comments = mock.Object.GetAll().Take(2);
            Assert.AreEqual(2, comments.Count());
        }

        private List<Comment> GetTestComments()
        {
            return new List<Comment>()
            {
                new Comment() {CommentId = 1},
                new Comment() {CommentId = 2},
                new Comment() {CommentId = 3}
            };
        }
    }
}