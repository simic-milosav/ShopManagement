namespace ShopManagementApp
{
    internal class Product
    {
        public string ProductId { get; set; }
        public float Price { get; set; }
        public float TaxedPrice { get; set; }
        public int Discount { get; set; }
        public int Stock { get; set; }
        public int SelectedAmount { get; set; }

        public Product() { }

        public Product(string productId, float price, int stock, int discount = 0)
        {
            ProductId = productId;
            Price = price;
            Stock = stock;
            Discount = discount;
            TaxedPrice = Price + Price * 0.2f;
        }

        public void ProductIsFree(bool isFree)
        {
            if (isFree)
                Price = 0;
        }
    }
}
