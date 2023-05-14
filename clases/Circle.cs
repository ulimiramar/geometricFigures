namespace geometricFigures;
public class Circle : ICalculable
{
    private double radio;
    public Circle(double radio)
    {
        this.radio = radio;
    }
    public double calculateArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public double calculatePerimeter()
    {
        return 2 * Math.PI * radio;
    }

    public override string ToString()
    {
        return $"Círculo: Radio={radio}, Perímetro={calculatePerimeter()}, Area={calculateArea()}";
    }
}