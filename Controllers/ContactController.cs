using Microsoft.AspNetCore.Mvc;

namespace MehendiWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Book Appointment";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string email, string phone, string service, string date, string message)
        {
            // In a real app, send email / save to DB
            TempData["Success"] = $"Thank you, {name}! Your appointment request has been received. We'll contact you at {email} within 24 hours.";
            return RedirectToAction("Index");
        }
    }
}
