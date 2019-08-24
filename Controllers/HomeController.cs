using Microsoft.AspNetCore.Mvc;
using parks_mvc.Models;

namespace parks_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}