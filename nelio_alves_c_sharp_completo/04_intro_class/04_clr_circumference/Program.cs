using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insert the radius: ");
            double radius = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

            Circumference circ = new Circumference(radius);

            Console.WriteLine("PI = " + Circumference.PI.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area = " + circ.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume = " + circ.Volume().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}