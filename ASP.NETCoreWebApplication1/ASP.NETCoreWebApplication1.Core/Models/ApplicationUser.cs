using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ASP.NETCoreWebApplication1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Rating { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<MessageModel> Messages { get; set; }
        public ApplicationUser()
        {
            Messages = new HashSet<MessageModel>();
        }
    }
}