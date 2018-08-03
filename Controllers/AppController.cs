using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact US";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About US";
            return View();
        }

    }
}