using System.Globalization;

namespace Exercise {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

            List<Employee> employees = new List<Employee>();

            for(int i=0; i<n; i++) {
                Console.WriteLine($"Emplyoee #{i+1}:");

                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                Employee employee = new Employee(id, name, salary);

                employees.Add(employee);
            }

            Console.WriteLine();
            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int idComp = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
            bool exists = false;

            foreach(Employee employee in employees) {
                if(idComp == employee.Id) {
                    Console.WriteLine("Enterthe percentage: ");
                    double percentage = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                    employee.increaseSalary(percentage);
                    exists = true;
                }
            }

            if(!exists) {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee employee in employees) {
                Console.WriteLine(employee);
            }
        }
    }
}