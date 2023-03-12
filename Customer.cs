using System.Diagnostics;

namespace WebshopOOP
{
    internal class Customer
    {
        //Contact info
        //Delivery address
        //List of orders
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }

        public Address DeliveryAddress { get; set; }
        public Address HomeAddress { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Email} {TelephoneNumber}";
        }
    }
}
