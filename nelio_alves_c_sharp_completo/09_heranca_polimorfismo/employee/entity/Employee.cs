using System.Globalization;

namespace Exercise.Entity {
    class Employee {
        public string Name { get; set; }
        public int Hour { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hour, double valuePerHour) {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() {
            return Hour * ValuePerHour;
        }

        public override string ToString() {
            return $"{Name} - $ {Payment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}