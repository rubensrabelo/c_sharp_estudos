using System;
using System.Globalization;

class Program {
    static void Main() {
        Triangle x, y;
        x = new Triangle();
        y = new Triangle();

        Console.WriteLine("Entre com as medidas do Triangulo X: ");
        x.A = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do Triangulo Y: ");
        y.A = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

        double areaX = x.Area();
        double areaY = y.Area();

        Console.WriteLine("Area de X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Area de Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));

        if(areaX > areaY) {
            Console.WriteLine("Maior area: X");
        } else if(areaY > areaX) {
            Console.WriteLine("Maior area: Y");
        } else {
            Console.WriteLine("Areas sao iguais");
        }
    }
}