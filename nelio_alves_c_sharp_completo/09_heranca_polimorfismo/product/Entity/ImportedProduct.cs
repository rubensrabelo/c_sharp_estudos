using System.Globalization;

namespace Exercise.Entity {
    class ImportedProduct : Product {
        public double CustomFee { get; set; }

        public ImportedProduct(
            string name,
            double price,
            double customFee
        ) : base(name, price) {
            CustomFee = customFee;
        }

        public double TotalPrice() {
            base.Price += CustomFee;
            return base.Price;
        }

        public override string PriceTag()
        {
            return $"{base.PriceTag()} (Custom fee: {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}