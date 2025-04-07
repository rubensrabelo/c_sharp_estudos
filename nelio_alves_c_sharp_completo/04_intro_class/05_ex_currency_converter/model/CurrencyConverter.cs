namespace Exercise {
    class CurrencyConverter {
        private static double IOF = 0.06;

        private double CurrentValue { get; set; }
        private double AmountToPay { get; set; }

        public CurrencyConverter(double currentValue, double amountToPay) {
            CurrentValue = currentValue;
            AmountToPay = amountToPay;
        }

        public double PurchaseValue() {
            double result = CurrentValue * AmountToPay;
            result += (result * CurrencyConverter.IOF);
            return result;
        }
    }
}