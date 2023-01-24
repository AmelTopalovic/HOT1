using System.ComponentModel.DataAnnotations;
namespace OrderForm.Models
{
	public class OrderFormModel


	{	public string? _discountCode;

		[Required(ErrorMessage = "You must enter a quantity!")]
		public int? Quantity { get; set; }

		public string? DiscountCode
		{
			get
			{
				return _discountCode;
			}
			set
			{
				_discountCode = value;
				if (_discountCode == "6175")
				{
					DiscountMessage = "30% discount applied!";
					PricePerShirt = PricePerShirt - (PricePerShirt * 0.30);
				}
				else if (_discountCode == "1390")
				{
					DiscountMessage = "20% discount applied!";
					PricePerShirt = PricePerShirt - (PricePerShirt * 0.20);
				}
				else if (_discountCode == "BB88")
				{
					DiscountMessage = "10% discount applied!";
					PricePerShirt = PricePerShirt - (PricePerShirt * 0.10);
				}
				else if (_discountCode == null)
				{
					DiscountMessage = string.Empty;
				}
				else
				{
					DiscountMessage = "* Invalid discount code!";
				}
			}
		}



		public string? DiscountMessage { get; set; }
		
		public double? PricePerShirt { get; set; } = 15.00;
		public double? Subtotal
		{
			get
			{
				return Quantity * PricePerShirt;
			}

		}
		public double? Tax {
			get
			{
				return Subtotal * 0.08;
			}
		}
		public double? Total
		{
			get
			{
				return Subtotal + Tax;
			}


		}

		public string? Summary
		{
			get
			{
				return $"{Quantity} shirts @ {PricePerShirt:C2} each\n"+
					$"-~-~-~-~-~-~-~-~-~-\n" +
					$"Subtotal: {Subtotal:C2}\n\n" +
					$"Tax: {Tax:C2}\n\n"+
					$"Total: {Total:C2}";
			}
		}
		
		
	}
}
