using Microsoft.AspNetCore.Mvc;
using OrderForm.Models;

namespace OrderForm.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(OrderFormModel model)
		{
			return View(model);
		}
	}
}
