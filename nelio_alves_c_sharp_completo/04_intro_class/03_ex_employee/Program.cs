using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine() ?? throw new ArgumentNullException();

            Console.WriteLine("Gross Salary: ");
            double grossSalary = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Console.WriteLine("Tax: ");
            double tax = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Employee employee = new Employee(name, grossSalary, tax);

            Console.WriteLine("\nEmployee: " + employee);

            Console.WriteLine("\nEnter the percentage to increase the salary: ");
            double percentage = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            employee.IncreaseSalary(percentage);

            Console.WriteLine("\nUpdated data: " + employee);
        }
    }
}