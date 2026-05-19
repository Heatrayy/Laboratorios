using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Bienvenido(a), " + nombre);

        Console.Write("Ingrese una contraseña: ");
        string contra = Console.ReadLine();

        bool mayuscula = false;
        bool numero = false;
        bool especial = false;
        bool longitud = false;

        if (contra.Length >= 8)
        {
            longitud = true;
        }

        for (int i = 0; i < contra.Length; i++)
        {
            if (contra[i] >= 'A' && contra[i] <= 'Z')
            {
                mayuscula = true;
            }

            if (contra[i] >= '0' && contra[i] <= '9')
            {
                numero = true;
            }

            if (contra[i] == '@' || contra[i] == '#' || contra[i] == '$' || contra[i] == '%')
            {
                especial = true;
            }
        }

        if (longitud && mayuscula && numero && especial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.Write("Inválida: ");

            if (!longitud)
            {
                Console.Write("falta longitud mínima ");
            }

            if (!mayuscula)
            {
                Console.Write("falta mayúscula ");
            }

            if (!numero)
            {
                Console.Write("falta número ");
            }

            if (!especial)
            {
                Console.Write("falta carácter especial ");
            }

            Console.WriteLine();
        }
    }
}
