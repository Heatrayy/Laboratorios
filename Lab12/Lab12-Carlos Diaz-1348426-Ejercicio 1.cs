using System;
class Program {
    static void Main() {
        
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
      
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        int[,] matriz = new int[4, 4];

        LlenarMatriz(matriz);

        Console.Write("Ingrese la fila a sumar (0-3): ");
        int fila = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la columna a sumar (0-3): ");
        int columna = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma de la fila: " + SumaFila(matriz, fila));
        Console.WriteLine("Suma de la columna: " + SumaColumna(matriz, columna));
        Console.ReadKey();
    }

    static void LlenarMatriz(int[,] m) {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++) {
                Console.Write($"Ingrese valor [{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaFila(int[,] m, int fila) {
        int suma = 0;
        for (int j = 0; j < 4; j++)
            suma += m[fila, j];
        return suma;
    }

    static int SumaColumna(int[,] m, int col) {
        int suma = 0;
        for (int i = 0; i < 4; i++)
            suma += m[i, col];
        return suma;
    }
}
