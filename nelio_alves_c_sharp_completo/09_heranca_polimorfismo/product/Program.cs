using System.Globalization;
using Exercise.Entity;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the number of products:");
            int n = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

            List<Product> products = new List<Product>();

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Product #{i+1} data:");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                string option = Console.ReadLine() ?? throw new ArgumentNullException();
                
                Console.WriteLine("Name:");
                string name = Console.ReadLine() ?? throw new ArgumentNullException();
                Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                switch(option) {
                    case "c":
                        products.Add(new Product(name, price));
                        break;
                    case "u":
                        Console.WriteLine("Manufacture date (DD/MM/YYYY):");
                        string dateStr = Console.ReadLine() ?? throw new ArgumentNullException();
                        DateTime date = DateTime.ParseExact(
                            dateStr,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture);
                        products.Add(new UsedProduct(name, price, date));
                        break;
                    case "i":
                        Console.WriteLine("Custom fee:");
                        double customFee = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customFee));
                        break;
                    default:
                        Console.WriteLine("The option entered is not valid.");
                        break;
                }
            }

            foreach(Product product in products) {
                Console.WriteLine($"{product.PriceTag()}\n");
            }
        }
    }
}