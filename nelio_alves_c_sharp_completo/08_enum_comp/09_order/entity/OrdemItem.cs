using System.Globalization;

namespace Exercise.Entity {
    class OrderItem {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product) {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal() {
            return Quantity * Product.Price;
        }

        public override string ToString() {
            return $"{Product}, Quantity: {Quantity}, " +
                $"SubTotal = {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}