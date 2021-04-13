namespace ShopManagementApp
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }

        public Customer() { }

        public Customer(string name, string surname, string address, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNumber = phoneNumber;
            Type = "BRONZE";
        }

        private void SetType(int orderCount)
        {
            if (orderCount > 10)
                Type = "GOLD";
            else if (orderCount > 5)
                Type = "SILVER";
        }
    }
}
