namespace ShopManagementApp
{
    internal class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public float TaxedPrice { get; set; }
        public int Discount { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public int Stock { get; set; }
        public bool IsFree { get; set; }

        public Product() { }

        public Product(string productId, string name, string color, string size, string brand, float price, string type, string subtype, int discount = 0)
        {
            ProductId = productId;
            Name = name;
            Color = color;
            Size = size;
            Brand = brand;
            Price = price;
            Type = type;
            Subtype = subtype;
            Discount = discount;
            TaxedPrice = Price + Price * 0.2f;
        }

        private void ProductIsFree(bool isFree)
        {
            if (isFree)
                Price = 0;
        }
    }
}
