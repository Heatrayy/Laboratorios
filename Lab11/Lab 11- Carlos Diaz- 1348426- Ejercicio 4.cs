using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Bienvenido(a), " + nombre);

        int[] numeros = new int[8];
        int buscar;
        bool encontrado = false;
        int posicion = -1;

        Console.WriteLine("Ingrese 8 números enteros:");

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ingrese el número que desea buscar: ");
        buscar = int.Parse(Console.ReadLine());

        for (int i = 0; i < 8; i++)
        {
            if (numeros[i] == buscar)
            {
                encontrado = true;
                posicion = i;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("El número sí existe en la posición " + posicion);
        }
        else
        {
            Console.WriteLine("El número no existe en el arreglo");
        }
    }
}
