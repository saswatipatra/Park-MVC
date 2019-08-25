using Microsoft.AspNetCore.Mvc;
using parks_mvc.Models;

namespace parks_mvc.Controllers
{
    public class ReviewsController : Controller
    {
        public ActionResult Create(int id)
        {
            ViewBag.NationalParkId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review)
        {
            Review.PostReview(review);
            return RedirectToAction("Details", "NationalParks", new { id = review.NationalParkId });
        }
    }
}