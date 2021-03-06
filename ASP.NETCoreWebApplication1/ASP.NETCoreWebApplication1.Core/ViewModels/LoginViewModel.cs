using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreWebApplication1.Core.ViewModels
{
  public class LoginViewModel
  {
    [Required, Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required, DataType(DataType.Password)] 
    public string Password { get; set; }
    
    [Display(Name = "Remember Me?")]
    public bool RememberMe { get; set; }
         
    public string ReturnUrl { get; set; }
  }
}