namespace Exercise.Entity {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public override string ToString() {
            return $"{Name}, {Price}";
        }
    }
}