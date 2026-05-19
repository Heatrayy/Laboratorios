using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Bienvenido(a), " + nombre);

        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido = invertido + texto[i];
        }

        Console.WriteLine("Texto invertido: " + invertido);
    }
}
