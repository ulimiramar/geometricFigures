namespace geometricFigures;
public class Square : ICalculable
{
    private double side;
    public Square(double side)
    {
        this.side = side;
    }
    public double calculateArea()
    {
        return Math.Pow(side, 2);
    }

    public double calculatePerimeter()
    {
        return 4 * side;
    }

    public override string ToString()
    {
        return $"Cuadrado: Lado={side}, Perímetro={calculatePerimeter()}, Area={calculateArea()}";
    }

}