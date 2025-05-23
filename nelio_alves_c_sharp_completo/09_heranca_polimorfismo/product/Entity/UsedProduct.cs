namespace Exercise.Entity {
    class UsedProduct : Product {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(
            string name,
            double price,
            DateTime manufactureDate
            ) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            return $"{base.PriceTag()} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}