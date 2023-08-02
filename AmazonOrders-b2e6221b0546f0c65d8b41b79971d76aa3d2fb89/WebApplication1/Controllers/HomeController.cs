using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //throw new Exception("This is an error");
            return View();
        }
        public IActionResult Test(int? id, string text)
        {
            // get the id from the Request url
            //var id = Request.RouteValues["id"];

            //pass the id value to the view
            ViewData.Add("id", id);
            // ViewData.id = id; new way using dynamic props
            ViewBag.searchText = text;
            return View();
        }
    }
}
