using System.Globalization;

namespace Course.Entity {
    class HourContract {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() {}

        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() {
            return ValuePerHour * Hours ;
        }

        public override string ToString() {
            return TotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}