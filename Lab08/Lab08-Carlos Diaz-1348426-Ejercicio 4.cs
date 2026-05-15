using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

        int numero;
        int totalNumeros = 0;
        int positivos = 0;
        int negativos = 0;
        int suma = 0;

        Console.WriteLine("Ingrese números (ingrese 0 para terminar):");

        do
        {
            Console.Write("Número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                totalNumeros++;
                suma += numero;

                if (numero > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }

        } while (numero != 0);

        Console.WriteLine("Resultados:");
        Console.WriteLine("Cantidad de números ingresados: " + totalNumeros);
        Console.WriteLine("Cantidad de números positivos: " + positivos);
        Console.WriteLine("Cantidad de números negativos: " + negativos);
        Console.WriteLine("Suma total: " + suma);
    }
}
