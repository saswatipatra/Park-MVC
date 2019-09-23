using System;
using Microsoft.AspNetCore.Mvc;
using parks_mvc.Models;

namespace parks_mvc.Controllers
{
    public class StatesController : Controller
    {
        public IActionResult Index()
        {
            var allStates = State.GetStates();
            return View(allStates);
        }

        public IActionResult IndexNext()
        {
            var nextStates = State.GetNextStates();
            return View("Index", nextStates);
        }

        public IActionResult IndexPrev()
        {
            var prevStates = State.GetPrevStates();
            return View("Index", prevStates);
        }

        public IActionResult Details(int id)
        {
            var particularState = State.GetPaticularStates(id);
            return View(particularState);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(State state)
        {
            State.PostState(state);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            State.DeleteState(id);
            return RedirectToAction("Index");
        }

        
        public IActionResult Edit(int id)
        {
            var particularState = State.GetPaticularStates(id);
            Console.WriteLine("inside state part1 edit");
            return View(particularState);
        }

        [HttpPost]
        public IActionResult Edit(int id, State state)
        {
            State.EditState(id,state);
            Console.WriteLine("inside state edit");
            return RedirectToAction("Index");
        }
    }
}