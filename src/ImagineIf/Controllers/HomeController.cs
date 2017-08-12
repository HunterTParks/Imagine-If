using Microsoft.AspNetCore.Mvc;

namespace ImagineIf.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
