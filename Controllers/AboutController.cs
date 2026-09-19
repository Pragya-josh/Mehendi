using Microsoft.AspNetCore.Mvc;

namespace MehendiWebsite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "About Us";
            return View();
        }
    }
}
