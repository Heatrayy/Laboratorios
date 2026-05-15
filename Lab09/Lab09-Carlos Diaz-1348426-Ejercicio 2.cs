using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al Lab 9 - Procedimientos");
        Console.WriteLine("Calculadora de Áreas");
        Console.WriteLine("--------------------");

        Console.Write("Ingrese el lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());
        AreaCuadrado(lado);

        Console.Write("\nIngrese la base del rectángulo: ");
        double baseR = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        double alturaR = double.Parse(Console.ReadLine());
        AreaRectangulo(baseR, alturaR);

        Console.Write("\nIngrese la base del triángulo: ");
        double baseT = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del triángulo: ");
        double alturaT = double.Parse(Console.ReadLine());
        AreaTriangulo(baseT, alturaT);

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }

    static void AreaCuadrado(double lado)
    {
        double area = lado * lado;
        Console.WriteLine($"\nÁrea del cuadrado: {area}");
    }

    static void AreaRectangulo(double baseR, double alturaR)
    {
        double area = baseR * alturaR;
        Console.WriteLine($"Área del rectángulo: {area}");
    }

    static void AreaTriangulo(double baseT, double alturaT)
    {
        double area = (baseT * alturaT) / 2;
        Console.WriteLine($"Área del triángulo: {area}");
    }
}
