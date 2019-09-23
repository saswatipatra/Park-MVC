using System;
using Microsoft.AspNetCore.Mvc;
using parks_mvc.Models;

namespace parks_mvc.Controllers
{
    public class NationalParksController : Controller
    {
        public IActionResult Index()
        {
            var allNationalParks = NationalPark.GetNationalParks();
            return View(allNationalParks);
        }

        public IActionResult Details(int id)
        {
            var particularNationalPark = NationalPark.GetPaticularNationalPark(id);
            return View(particularNationalPark);
        }
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
        public IActionResult Delete(int id)
        {
            NationalPark.DeleteNationalPark(id);
            return RedirectToAction("Index","states");
        }

        
        public IActionResult Edit(int id)
        {
            
            var particularNationalPark = NationalPark.GetPaticularNationalPark(id);
            Console.WriteLine("inside edit part 1");
            return View(particularNationalPark);
        }

        [HttpPost]
        public IActionResult Edit(int id, NationalPark nationalPark)
        {
            NationalPark.EditNationalPark(id,nationalPark);
            Console.WriteLine("inside edit");
            return RedirectToAction("Index","states");
        }
    }
}