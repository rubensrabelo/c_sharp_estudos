using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What is the dollar rate? ");
            double currentValue = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Console.WriteLine("How many dollars will you buy? ");
            double amountToPay = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            CurrencyConverter cc = new CurrencyConverter(currentValue, amountToPay);

            Console.WriteLine("\nAmount to be paid in reais = " + cc.PurchaseValue().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}