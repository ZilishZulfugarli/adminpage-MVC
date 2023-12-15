using System;
namespace admin_panel.Entities
{
	public class ProductImage
	{
		public int Id { get; set; }
		public string ImageName { get; set; }

		public Product Product { get; set; }
	}
}

