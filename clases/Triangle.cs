namespace geometricFigures;
public class Triangle : ICalculable
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public double calculateArea()
    {
        // Calculamos el semiperímetro
        double s = (side1 + side2 + side3) / 2;

        // Calculamos el área utilizando la fórmula de Herón
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

        return area;
    }
    public double calculatePerimeter()
    {
        return side1 + side2 + side3;
    }

    public double calculateHeight()
    {
        // Calculamos el semiperímetro
        double s = (side1 + side2 + side3) / 2;

        // Calculamos la altura utilizando la fórmula de Herón
        double height = (2 * Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3))) / side1;

        return height;
    }
    public override string ToString()
    {
        return $"Triángulo: Lado1={side1}, Lado2={side2}, Lado3={side3}, Altura={calculateHeight()}, Perímetro={calculatePerimeter()}, Area={calculateArea()}";
    }
}