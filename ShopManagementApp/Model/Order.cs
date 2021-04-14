using System;
using System.Collections.Generic;

namespace ShopManagementApp
{
    internal class Order
    {
        public int OrderId { get; set; }
        public float Price { get; set; }
        public float Shipping { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public Order(DateTime created)
            : this()
        {
            Created = created;
        }

        public void CalculatePrice()
        {
            foreach (Product product in Products)
                Price += (product.TaxedPrice - product.TaxedPrice * product.Discount / 100) * product.SelectedAmount;
            Price += Shipping;
        }
    }
}
