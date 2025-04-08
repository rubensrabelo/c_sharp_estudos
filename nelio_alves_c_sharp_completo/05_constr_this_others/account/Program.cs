using System;
using System.Globalization;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter the account number: ");
            string id = Console.ReadLine() ?? throw new ArgumentNullException();

            Console.WriteLine("Enter the account holder: ");
            string name = Console.ReadLine() ?? throw new ArgumentNullException();

            Console.WriteLine("Will there be an initial deposit (y/n)? ");
            string option = Console.ReadLine() ?? throw new ArgumentNullException();

            double balance = 0.0;

            if(option == "y") {
                Console.WriteLine("Enter the initial deposit amount:");
                balance  = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
            }

            Account ac = new Account(id, name, balance);

            Console.WriteLine("Data Account");
            Console.WriteLine(ac + "\n");

            Console.WriteLine("Enter an amount to deposit:");
            balance  = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
            ac.deposit(balance);
            
            Console.WriteLine("Updated account details:");
            Console.WriteLine(ac + "\n");

            Console.WriteLine("Entre um valor para saque:");
            balance  = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
            ac.Withdrawn(balance);
            
            Console.WriteLine("Updated account details:");
            Console.WriteLine(ac + "\n");
        }
    }
}