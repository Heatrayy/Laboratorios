using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Bienvenido(a), " + nombre);

        Console.Write("¿Cuántos números va a ingresar?: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];
        int suma = 0;
        int mayor;
        int menor;
        double promedio;

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        mayor = numeros[0];
        menor = numeros[0];

        for (int i = 0; i < cantidad; i++)
        {
            suma = suma + numeros[i];

            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        promedio = (double)suma / cantidad;

        Console.WriteLine("Suma = " + suma);
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Mayor = " + mayor);
        Console.WriteLine("Menor = " + menor);
    }
}
