using System.Globalization;

namespace Exercise {
    public class Employee {
        private String Name {get; set;}
        private double GrossSalary {get; set;}
        private double Tax {get; set;}

        public Employee(string Name, double GrossSalary, double Tax) {
            this.Name = Name;
            this.GrossSalary = GrossSalary;
            this.Tax = Tax;
        }

        public double NetSalary() {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage) {
            GrossSalary += (GrossSalary * (percentage/100));
        }

        public override string ToString() {
            return Name + ", $ "+ NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}