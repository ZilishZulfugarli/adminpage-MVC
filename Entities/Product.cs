using System;
namespace admin_panel.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string? ProductImageId { get; set; }
		public int CategoryId { get; set; }

		public ProductImage? productImage { get; set; }
		public Category Category { get; set; }
		public List<Order> Orders { get; set; }
	}
}

