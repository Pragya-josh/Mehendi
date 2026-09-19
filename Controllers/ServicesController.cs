using Microsoft.AspNetCore.Mvc;

namespace MehendiWebsite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Services";
            return View();
        }
    }
}
