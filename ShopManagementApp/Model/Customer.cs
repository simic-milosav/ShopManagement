namespace ShopManagementApp
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public int OrdersNum { get; set; }
        public string Type { get; set; }

        public void SetType()
        {
            if (OrdersNum > 10)
                Type = "GOLD";
            else if (OrdersNum > 5)
                Type = "SILVER";
        }
    }
}
