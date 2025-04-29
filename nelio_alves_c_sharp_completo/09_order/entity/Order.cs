using System.Globalization;
using System.Text;
using Exercise.Entity.Enums;

namespace Exercise.Entity {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(OrderStatus status, Client client) {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double total = 0.0;

            foreach(OrderItem item in Items) {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder();
            output.Append($"Order moment: {Moment.ToString()}");
            output.Append($"Order status: {Status}");
            output.Append(Client);

            output.Append("Order items:");
            foreach(OrderItem item in Items) {
                output.Append(item);
            }

            output.Append($"Total price {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return output.ToString();
        }
    }
}