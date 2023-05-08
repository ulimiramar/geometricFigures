namespace geometricFigures;
public class Circle : Figure
{
    private double radio;
    public Circle(double radio)
    {
        this.radio = radio;
    }
    public double getRadio {get {return radio;}}
    public override double calculateArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public override double calculatePerimeter()
    {
        return 2 * Math.PI * radio;
    }

    public override string ToString()
    {
        return $"Círculo: Radio={radio}, Perimetro={calculatePerimeter()}, Area={calculateArea()}";
    }
}