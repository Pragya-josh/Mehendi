using Microsoft.AspNetCore.Mvc;

namespace MehendiWebsite.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Gallery";
            return View();
        }
    }
}
