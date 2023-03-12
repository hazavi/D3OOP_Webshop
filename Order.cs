using System.Text;

namespace WebshopOOP
{
    internal class Order
    {
        //Product
        //Amount of products
        //Total price
        //DateTime When order is placed
        //Paid
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public bool IsPaid { get; set; }

        public override string ToString()
        {
            string sb = $"{Id} {Customer}\n {Created}";
            foreach (var item in ProductOrders)
            {
                sb += item;
            }

            return sb;
        }
    }
}
