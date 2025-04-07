using System;

namespace Exercise {
    class Circumference {
        public static double PI = 3.14;

        private double Radius { get; set;}

        public Circumference(double radius) {
            this.Radius = radius;
        }

        public double Area() {
            return Circumference.PI * Math.Pow(Radius, 2);
        }

        public double Volume() {
            return 4.0 / 3.0 * Circumference.PI * Math.Pow(Radius, 3);
        }
    }
}