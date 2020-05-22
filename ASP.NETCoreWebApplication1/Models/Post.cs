using System;
using System.Collections.Generic;

namespace ASP.NETCoreWebApplication1.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }
        public DateTime TimeStamp { get; set; }
        public Category Category { get; set; }
        public ApplicationUser Owner { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public Files File { get; set; }
        public List<ApplicationUser> userVotes { get; set; }
    }
}
