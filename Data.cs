using System.Text.Json;

namespace WebshopOOP
{
    internal class Data
    {
        private string jsonAddress = "[{\"StreetName\":\"Portage\",\"StreetNumber\":285,\"City\":\"Shuhong\",\"PostalCode\":2693,\"Country\":\"China\"},\r\n{\"StreetName\":\"Pierstorff\",\"StreetNumber\":783,\"City\":\"Bucu Kidul\",\"PostalCode\":7680,\"Country\":\"Indonesia\"},\r\n{\"StreetName\":\"Golden Leaf\",\"StreetNumber\":640,\"City\":\"Zelmeņi\",\"PostalCode\":4756,\"Country\":\"Latvia\"},\r\n{\"StreetName\":\"Summit\",\"StreetNumber\":438,\"City\":\"Aquin\",\"PostalCode\":2873,\"Country\":\"Haiti\"},\r\n{\"StreetName\":\"Leroy\",\"StreetNumber\":545,\"City\":\"Mertzig\",\"PostalCode\":3050,\"Country\":\"Luxembourg\"},\r\n{\"StreetName\":\"Carberry\",\"StreetNumber\":777,\"City\":\"Buenos Aires\",\"PostalCode\":5692,\"Country\":\"Mexico\"},\r\n{\"StreetName\":\"Shoshone\",\"StreetNumber\":71,\"City\":\"Houston\",\"PostalCode\":2170,\"Country\":\"United States\"},\r\n{\"StreetName\":\"Hanover\",\"StreetNumber\":725,\"City\":\"Créteil\",\"PostalCode\":8623,\"Country\":\"France\"},\r\n{\"StreetName\":\"Atwood\",\"StreetNumber\":364,\"City\":\"Montevista\",\"PostalCode\":9656,\"Country\":\"Philippines\"},\r\n{\"StreetName\":\"Bonner\",\"StreetNumber\":774,\"City\":\"Bun Barat\",\"PostalCode\":2749,\"Country\":\"Indonesia\"}]";
        private string jsonCustomer = "[{\"Id\":9082,\"Name\":\"Octavia Grendon\",\"Email\":\"ogrendon0@cbsnews.com\",\"TelephoneNumber\":\"8574291214\"},\r\n{\"Id\":8285,\"Name\":\"Austen Rimmington\",\"Email\":\"arimmington1@google.co.uk\",\"TelephoneNumber\":\"6466595488\"},\r\n{\"Id\":6448,\"Name\":\"Hendrik Kuschek\",\"Email\":\"hkuschek2@intel.com\",\"TelephoneNumber\":\"6773279721\"},\r\n{\"Id\":5745,\"Name\":\"Vergil Rawood\",\"Email\":\"vrawood3@webs.com\",\"TelephoneNumber\":\"6302997408\"},\r\n{\"Id\":8865,\"Name\":\"Valeria Rogger\",\"Email\":\"vrogger4@intel.com\",\"TelephoneNumber\":\"9069262596\"},\r\n{\"Id\":4586,\"Name\":\"Kippy Yashaev\",\"Email\":\"kyashaev5@abc.net.au\",\"TelephoneNumber\":\"7711995366\"},\r\n{\"Id\":5041,\"Name\":\"Petronella Tufts\",\"Email\":\"ptufts6@unesco.org\",\"TelephoneNumber\":\"7612677420\"},\r\n{\"Id\":7628,\"Name\":\"Ripley Lanyon\",\"Email\":\"rlanyon7@discovery.com\",\"TelephoneNumber\":\"5692090796\"},\r\n{\"Id\":1619,\"Name\":\"Charlot McGillivray\",\"Email\":\"cmcgillivray8@tinyurl.com\",\"TelephoneNumber\":\"4533508094\"},\r\n{\"Id\":9357,\"Name\":\"Sarina Skeates\",\"Email\":\"sskeates9@nifty.com\",\"TelephoneNumber\":\"5818459663\"}]";
        public List<Product> Products = new();
        public List<Address> AddressList = new();
        public List<Customer> Customers = new();
        public List<Order> Orders= new();

        public Data()
        {
            AddProducts();
            AddressList = JsonSerializer.Deserialize<List<Address>>(jsonAddress);
            Customers = JsonSerializer.Deserialize<List<Customer>>(jsonCustomer);
            int i = 0;
            foreach (var item in Customers)
            {
                item.HomeAddress = AddressList[i++];
            }
            CreateFakeOrders();
        }
        public void AddProducts()
        {
            Products.Add(new Product("Balenciaga Track Runner", 6000, 7200, 50, ProductType.Shoes));
            Products.Add(new Product("C.P. COMPANY - Crossbody Bag", 1000, 1500, 100, ProductType.Bags));
            Products.Add(new Product("RICK OWENS - Cropped Leather Bomber Jacket", 15000, 17000, 20, ProductType.Clothing));
            

        }

        public List<string> GetProductList()
        {
            List<string> prod = new();
            foreach (var item in Products)
                prod.Add(item.ToString());
            return prod;
        }

        public List<string> GetCustomers()
        {
            List<string> cust = new();
            foreach (var item in Customers)
                cust.Add(item.ToString());
            return cust;
        }

        public void CreateFakeOrders()
        {
            for (int i = 0; i < 100; i++)
            {
                Order o = new Order();
                o.Id = i;
                o.Customer = Customers[new Random().Next(Customers.Count)];
                o.ProductOrders = new List<ProductOrder>()
                {
                    new ProductOrder() { Product = Products[1], Amount = 1 }
                };
                Orders.Add(o);
            }

        }

        internal List<string> GetOrders()
        {
            List<string> orders = new();
            foreach (var item in Orders)
                orders.Add(item.ToString());
            return orders;
        }
    }
}
