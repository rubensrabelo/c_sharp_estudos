using System.Globalization;

namespace Example {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {
            Name = "";
            Price = 0.0;
        }
        
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                ", Price = " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}