using System.Globalization;

namespace Example {
    class Program {
        static void Main(string[] args) {
            int size = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Product[] prods = new Product[size];

            for(int i = 0; i < prods.Length; i++) {
                string name = Console.ReadLine() ?? throw new ArgumentNullException();
                double price = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                prods[i] = new Product(name, price);
            }

            double sum_price = 0.0;

            foreach(Product p in prods) {
                sum_price += p.Price;
            }

            double average_price = sum_price / prods.Length;

            Console.WriteLine("AVERAGE PRICE = " + average_price);
        }
    }
}