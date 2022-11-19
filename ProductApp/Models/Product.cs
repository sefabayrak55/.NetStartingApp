using System;
namespace ProductApp.Models
{
	public class Product
	{
		public int Id { get; set; }

		public string productName { get; set; }

		public decimal price { get; set; }

        public Product(int id, string productName, decimal price)
        {
            Id = id;
            this.productName = productName;
            this.price = price;
        }

        public Product()
		{

		}
	}
}

