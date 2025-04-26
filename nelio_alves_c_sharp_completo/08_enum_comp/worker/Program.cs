using System.Globalization;
using Course.Entity;
using Course.Entity.enums;

namespace Course {
    public class Program {
        public static void Main(string[] args) {

            Console.WriteLine("Enter department's name:");
            string name = Console.ReadLine() ?? throw new ArgumentNullException();

            Departament departament = new Departament(name);

            Console.WriteLine();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            name = Console.ReadLine() ?? throw new ArgumentNullException();

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine() ?? throw new ArgumentNullException();

            WorkerLevel levelEnum = (WorkerLevel) Enum.Parse(typeof(WorkerLevel), level);

            Console.WriteLine("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, levelEnum, baseSalary, departament);

            Console.WriteLine();
            Console.WriteLine("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

            for(int i=0; i<n; i++) {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.WriteLine("Date (DD/MM/YYYY):");
                string dateStr = Console.ReadLine() ?? throw new ArgumentNullException();

                DateTime date = DateTime.ParseExact(dateStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.WriteLine("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duration(hours):");
                int hour = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

                HourContract hourContract = new HourContract(date, valuePerHour, hour);

                worker.AddContract(hourContract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            String monthYear = Console.ReadLine() ?? throw new ArgumentNullException();

            String[] parts = monthYear.Split("/");

            int month = int.Parse(parts[0]);
            int year = int.Parse(parts[1]);

            double valueIncome = worker.Income(month, year);

            Console.WriteLine();
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament}");
            Console.WriteLine($"Income for {monthYear}: {valueIncome}");
        }
    }
}