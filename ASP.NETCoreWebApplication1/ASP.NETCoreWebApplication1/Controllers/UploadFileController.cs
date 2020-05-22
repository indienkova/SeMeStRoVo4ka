using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication1.Controllers
{
    public class UploadFileController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return Ok();
        }

        public IActionResult Create(IFormFile file)
        {
            return Ok();
        }
    }
}