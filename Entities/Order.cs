using System;
namespace admin_panel.Entities
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public int ProductId { get; set; }
		public int CustomerId { get; set; }

		public List<Product> Products { get; set; }
		public List<Customer> Customers { get; set; }
	}
}

