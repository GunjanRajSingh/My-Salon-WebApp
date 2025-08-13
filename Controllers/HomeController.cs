using Microsoft.AspNetCore.Mvc;
using SalonWebsite.Models;

namespace SalonWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Thank you, we will contact you soon!";
                return View();
            }
            return View(form);
        }
    }
}
