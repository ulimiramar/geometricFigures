using System;
using System.Collections.Generic;

namespace geometricFigures
{
    class Program
    {
        static void Main(String[] args)
        {
            List<Figure> figures = new List<Figure>();
            bool keepCreating = true;
            while (keepCreating)
            {
                Console.WriteLine("¿Qué figura geométrica quiere crear?");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Círculo");
                Console.WriteLine("Escribe el número de la opción que deseas crear: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Ingresa el lado del cuadrado: ");
                        double squareSide = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square(squareSide);
                        figures.Add(square);
                        Console.WriteLine("Cuadrado creado.");
                        break;

                    case 2:
                        Console.Write("Ingresa el lado 1 del triángulo: ");
                        double triangleSide1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingresa el lado 2 del triángulo: ");
                        double triangleSide2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingresa el lado 3 del triángulo: ");
                        double triangleSide3 = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(triangleSide1,triangleSide2,triangleSide3);
                        figures.Add(triangle);
                        Console.WriteLine("Triángulo creado.");
                        break;

                    case 3:
                        Console.Write("Ingresa el radio del círculo: ");
                        double circleRadio = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(circleRadio);
                        figures.Add(circle);
                        Console.WriteLine("Círculo creado.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.Write("¿Quieres crear otra figura geométrica? (S/N)");
                string? answer = Console.ReadLine();
                if (answer.ToLower() != "s")
                {
                    keepCreating = false;
                }
            }
            
            Console.WriteLine("\nResumen de las figuras geométricas creadas:\n");
            foreach (Figure figure in figures)
            {
                Console.WriteLine(figure.ToString());
            }
            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();

        }
    }
}