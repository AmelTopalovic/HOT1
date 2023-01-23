using Microsoft.AspNetCore.Mvc;
using DistanceConverter.Models;

namespace DistanceConverter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.distanceInInches = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(DistanceConverterModel model)
        {
            if (ModelState.IsValid)
            {
                   ViewBag.distanceInCm = model.CalcToCM();
            }
            else
            {
                ViewBag.distanceInCm = 0;
            }
            return View();
        }
    }

   
}
