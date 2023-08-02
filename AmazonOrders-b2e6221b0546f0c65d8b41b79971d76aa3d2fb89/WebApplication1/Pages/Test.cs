using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Pages
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
