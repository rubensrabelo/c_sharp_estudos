using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter product's name:");
            string name = Console.ReadLine() ?? throw new ArgumentNullException();

            Console.WriteLine("Enter product's price: ");
            double price = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter product's quantity: ");
            int quantity = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Product prod = new Product(name, price, quantity);

            Console.WriteLine(prod + "\n");

            Console.WriteLine("Add quantity in the product: ");
            quantity = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            prod.AddProduct(quantity);

            Console.WriteLine(prod + "\n");

            Console.WriteLine("Remove quantity in the product: ");
            quantity = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            prod.RemoveProduct(quantity);

            Console.WriteLine(prod + "\n");
        }
    }
} 