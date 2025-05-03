using System.Globalization;
using Exercise.Entity;
using Exercise.Entity.Enums;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter client data");
            
            Console.WriteLine("Name: ");
            string name = Console.ReadLine() ?? throw new ArgumentNullException();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine() ?? throw new ArgumentNullException();
            Console.WriteLine("Birthdate (DD/MM/YYYY): ");
            string birthDateStr = Console.ReadLine() ?? throw new ArgumentNullException();

            DateTime birthDate = DateTime.ParseExact(
                birthDateStr,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status: ");
            string statusStr = Console.ReadLine() ?? throw new ArgumentNullException();

            OrderStatus status = Enum.Parse<OrderStatus>(statusStr);

            Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

            Order order = new Order(status, client); 

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.WriteLine("Product name:");
                string productName = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Product price:");
                double price = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity:");
                int quantity = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

                OrderItem item = new OrderItem(quantity, product);

                order.AddItem(item);
            }

            Console.WriteLine("");
            Console.WriteLine(order);
        }
    }
}