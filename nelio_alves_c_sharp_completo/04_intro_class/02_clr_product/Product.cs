using System.Globalization;

namespace Course {
    public class Product {
        private string Name { get; set; }
        private double Price { get; set;}
        private int Quantity { get; set; }

        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValueInStock() {
            return Price * Quantity;
        }

        public void AddProduct(int quantity) {
            this.Quantity += quantity;
        }

        public void RemoveProduct(int quantity) {
            this.Quantity -= quantity;
        }

        public override string ToString() {
            return "Name = " + Name +
                ", Price = $" + Price.ToString("F2", CultureInfo.InvariantCulture) +
                ", Quantity = " + Quantity +
                ", Total value in Stock = " + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}