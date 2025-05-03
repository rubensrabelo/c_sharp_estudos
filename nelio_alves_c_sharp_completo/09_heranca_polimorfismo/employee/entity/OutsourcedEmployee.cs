namespace Exercise.Entity {
    class OutsourcedEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(
            string name,
            int hour,
            double valuePerHour, 
            double additionalCharge
            ) : base(name, hour, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            return base.Payment() + AdditionalCharge *1.1;
        }
    }
}