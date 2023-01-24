using Microsoft.AspNetCore.Mvc;
using DistanceConverter.Models;

namespace DistanceConverter.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.distanceInInches = 0.0;
			ViewBag.distanceInCentimeters = 0.0;
			ViewBag.convertedString = 0;

			return View();
		}
		[HttpPost]
		public IActionResult Index(DistanceConverterModel model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.distanceInInches = model.DistanceInInches;
				ViewBag.distanceInCentimeters = model.DistanceInCentimeters;
				ViewBag.convertedString = model.ConvertedString;

			}
			else
			{
				ViewBag.distanceInInches = 0.0;
				ViewBag.distanceInCentimeters = 0.0;
				ViewBag.convertedString = 0;

			}
			return View(model);
		}

	}
		

   
}
