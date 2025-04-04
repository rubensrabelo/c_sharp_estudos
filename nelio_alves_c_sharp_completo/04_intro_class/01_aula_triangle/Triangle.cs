class Triangle {
    public double A;
    public double B;
    public double C;

    public double Perimeter() {
        return (A + B + C) / 2;
    }

    public double Area() {
        double p = Perimeter();

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override string ToString() {
        return "Triangle(A="+A+", B="+B+", C="+C+")";
    }
}