using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Bienvenido(a), " + nombre);

        string[] nombres = new string[5];
        int masDe5 = 0;
        string nombreLargo = "";

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese el nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();

            if (nombres[i].Length > 5)
            {
                masDe5++;
            }

            if (nombres[i].Length > nombreLargo.Length)
            {
                nombreLargo = nombres[i];
            }
        }

        Console.WriteLine("Nombres ingresados:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nombres[i]);
        }

        Console.WriteLine("Cantidad de nombres con más de 5 letras: " + masDe5);
        Console.WriteLine("Nombre más largo: " + nombreLargo);
    }
}
