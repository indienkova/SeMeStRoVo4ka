using System.Collections.Generic;

namespace ASP.NETCoreWebApplication1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
