using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreWebApplication1.Core.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
