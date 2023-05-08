namespace geometricFigures;
public class Square : Figure
{
    private double side;
    public Square(double side)
    {
        this.side = side;
    }

    public double getSide {get { return side;}}
    public override double calculateArea()
    {
        return Math.Pow(side, 2);
    }

    public override double calculatePerimeter()
    {
        return 4 * side;
    }

    public override string ToString()
    {
        return $"Cuadrado: Lado={side}, Perimetro={calculatePerimeter()}, Area={calculateArea()}";
    }

}