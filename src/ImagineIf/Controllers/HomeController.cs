using Microsoft.AspNetCore.Mvc;
using ImagineIf.Models;

namespace ImagineIf.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var allMessages = Channel.GetMessages();
            return View(allMessages);
        }
    }
}
