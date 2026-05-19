using System;
class Program {
    static void Main() {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        int[,] A = new int[3, 2];
        int[,] B = new int[3, 2];
        int[,] R = new int[3, 2];

        Console.WriteLine("Matriz A");
        Llenar(A);

        Console.WriteLine("\nMatriz B");
        Llenar(B);

        Multiplicar(A, B, R);

        Console.WriteLine("\nMatriz Resultante:");
        Mostrar(R);
        Console.ReadKey();
    }

    static void Llenar(int[,] m) {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++) {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static void Multiplicar(int[,] A, int[,] B, int[,] R) {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
                R[i, j] = A[i, j] * B[i, j];
    }

    static void Mostrar(int[,] m) {
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 2; j++)
                Console.Write(m[i, j] + "\t");
            Console.WriteLine();
        }
    }
}
