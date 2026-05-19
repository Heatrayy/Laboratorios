using System;
class Program {
    static void Main() {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        float[,] matriz = new float[3, 5];
        CargarMatriz(matriz);

        Console.WriteLine("El número mayor es: " + MayorMatriz(matriz));
        Console.ReadKey();
    }

    static void CargarMatriz(float[,] m) {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++) {
                Console.Write($"Ingrese valor [{i},{j}]: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
    }

    static float MayorMatriz(float[,] m) {
        float mayor = m[0, 0];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                if (m[i, j] > mayor)
                    mayor = m[i, j];
        return mayor;
    }
}
``
