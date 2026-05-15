using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
        int numero;
        int contador = 1;
        int suma = 0;
        int pares = 0;
        int impares = 0;

        Console.Write("Ingrese un número entero: ");
        numero = int.Parse(Console.ReadLine());

        while (contador <= numero)
        {
            suma += contador;

            if (contador % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            contador++;
        }

        Console.WriteLine("Resultados:");
        Console.WriteLine("Suma de los números del 1 al " + numero + ": " + suma);
        Console.WriteLine("Cantidad de números pares: " + pares);
        Console.WriteLine("Cantidad de números impares: " + impares);
    }
}
