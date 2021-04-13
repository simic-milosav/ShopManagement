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
        public bool IsShipped { get; set; }
        public List<Product> Products { get; set; }

        public Order() { }

        public Order(float shipping, List<Product> products)
        {
            Shipping = shipping;
            Products = products;
            Created = DateTime.Now;
        }

        private void CalculatePrice()
        {
            foreach (Product product in Products)            
                if (!product.IsFree)                
                    Price += product.TaxedPrice - product.TaxedPrice * product.Discount / 100;
            Price += Shipping;
        }
    }
}
