using Microsoft.AspNetCore.Mvc;
using parks_mvc.Models;

namespace parks_mvc.Controllers
{
    public class NationalParksController : Controller
    {
        public ActionResult Create(int id)
        {
            ViewBag.StateId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(NationalPark nationalPark)
        {
            NationalPark.PostNationalPark(nationalPark);
            return RedirectToAction("Details", "States", new { id = nationalPark.StateId });
        }
    }
}