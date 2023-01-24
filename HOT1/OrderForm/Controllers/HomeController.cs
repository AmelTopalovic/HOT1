using Microsoft.AspNetCore.Mvc;
using OrderForm.Models;

namespace OrderForm.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.quantity = 0;
			ViewBag.discountCode = null;
			ViewBag.pricePerShirt = 0.0;
			ViewBag.subtotal = 0.0;
			ViewBag.tax = 0.0;
			ViewBag.total = 0.0;
			ViewBag.summary = null;

			return View();
		}
		[HttpPost]
		public IActionResult Index(OrderFormModel model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.quantity = model.Quantity;
				ViewBag.discountCode = model.DiscountCode;
				ViewBag.pricePerShirt = model.PricePerShirt;
				ViewBag.discountMessage = model.DiscountMessage;
				ViewBag.subtotal = model.Subtotal;
				ViewBag.tax = model.Tax;
				ViewBag.total = model.Total;
				ViewBag.summary = model.Summary;

			}
			else
			{
				ViewBag.quantity = 0;
				ViewBag.discountCode = null;
				ViewBag.discountMessage = null;
				ViewBag.pricePerShirt = 0.0;
				ViewBag.subtotal = 0.0;
				ViewBag.tax = 0.0;
				ViewBag.total = 0.0;

			}
			return View(model);
		}
	}
}
