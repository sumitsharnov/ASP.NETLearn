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
            ////for pages
            ////throw new System.Exception("Bad Things happen"); 
            return View();
        }

        [HttpPost("Contact")]
        public IActionResult Contact(object model)
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About US";
            return View();
        }

    }
}