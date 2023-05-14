namespace geometricFigures;
public class Triangle : ICalculable
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            throw new TrianguloInvalidoException("el valor de la suma de los lados más cortos debe ser mayor que el del lado más largo.");
        }

        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public double calculateArea()
    {
        double s = calculateSemiPerimeter();
        //fórmula de herón para calcular el área
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public double calculatePerimeter()
    {
        return side1 + side2 + side3;
    }

    public double calculateSemiPerimeter()
    {
        return (calculatePerimeter())/2;
    }

    public double calculateHeight()
    {
        // Calculamos la altura utilizando la fórmula de Herón
        return (2 * calculateArea()) / side1;
    }

    public override string ToString()
    {
        return $"Triángulo: Lado1={side1}, Lado2={side2}, Lado3={side3}, Altura={calculateHeight()}, Perímetro={calculatePerimeter()}, Area={calculateArea()}";
    }

}