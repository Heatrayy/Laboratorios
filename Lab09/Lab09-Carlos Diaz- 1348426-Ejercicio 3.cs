using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("Bienvenido al Laboratorio numero 9");
            Console.WriteLine("Menu de figuras");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Linea");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese N: ");
                int n = int.Parse(Console.ReadLine());
                Cuadrado(n);
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese N: ");
                int n = int.Parse(Console.ReadLine());
                Triangulo(n);
            }
            else if (opcion == 3)
            {
                Console.Write("Ingrese N: ");
                int n = int.Parse(Console.ReadLine());
                Linea(n);
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo...");
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }

        } while (opcion != 4);
    }

    static void Cuadrado(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Triangulo(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Linea(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
