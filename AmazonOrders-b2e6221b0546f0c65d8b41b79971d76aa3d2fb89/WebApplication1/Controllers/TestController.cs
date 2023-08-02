using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var firstName = Request.Query["firstName"];
            ViewBag.FirstName = firstName;
 


            return View();
        }
        public IActionResult RazorTest()
        {

            return View();
        }

    }
}
