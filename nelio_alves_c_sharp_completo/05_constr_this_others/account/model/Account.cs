using System.Globalization;

namespace BankAccount {
    class Account {
        private string Id;
        private double Balance;
        private string Name { get; set; }

        public Account(string id, string name) {
            Id = id;
            Name = name;
            Balance = 0;
        }

        public Account(string id, string name, double balance) {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void Withdrawn(double amount) {
            Balance -= amount + 5;
        }

        public void deposit(double amount) {
            Balance += amount;
        }

        public override string ToString()
        {
            return "Account: " + Id + 
                ", Holder: " + Name + 
                ", Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}