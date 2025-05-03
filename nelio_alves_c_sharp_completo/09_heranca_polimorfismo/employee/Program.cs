using System.Globalization;
using Exercise.Entity;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i+1} data:");

                Console.WriteLine("Outsourced (y/n)?");
                string option = Console.ReadLine() ?? throw new ArgumentNullException();
                
                Console.WriteLine("Name:");
                string name = Console.ReadLine() ?? throw new ArgumentNullException();
                Console.WriteLine("Hours:");
                int hour = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                Console.WriteLine("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                if(option == "y") {
                    Console.WriteLine(" Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                    OutsourcedEmployee outsourcedEmployee = new OutsourcedEmployee(name, hour, valuePerHour, additionalCharge);

                    employees.Add(outsourcedEmployee);
                } else {
                    Employee employee = new Employee(name, hour, valuePerHour);

                    employees.Add(employee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee employee in employees) {
                Console.WriteLine(employee);
            }
        }
    }
}