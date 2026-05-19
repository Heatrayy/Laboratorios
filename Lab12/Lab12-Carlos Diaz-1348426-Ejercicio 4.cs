using System;
class Program {
    static void Main() {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        int[,] matriz = new int[5, 5];
        Llenar(matriz);

        Console.WriteLine("Suma diagonal principal: " +
            SumaDiagonalPrincipal(matriz));
        Console.WriteLine("Suma diagonal secundaria: " +
            SumaDiagonalSecundaria(matriz));
        Console.ReadKey();
    }

    static void Llenar(int[,] m) {
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++) {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaDiagonalPrincipal(int[,] m) {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, i];
        return suma;
    }

    static int SumaDiagonalSecundaria(int[,] m) {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, 4 - i];
        return suma;
    }
}
