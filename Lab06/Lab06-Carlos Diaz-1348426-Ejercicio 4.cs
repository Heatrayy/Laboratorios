using System;

class Ejercicio3
{
    static void Main()
    {
        Console.WriteLine("Evaluación de rendimiento del empleado");
        Console.WriteLine("Puntuaciones válidas: 0.0, 0.4, 0.6 o más");
        Console.Write("Ingrese la puntuación del empleado: ");

        double puntuacion = double.Parse(Console.ReadLine());
        double dinero = 2400 * puntuacion;

        if (puntuacion == 0.0)
        {
            Console.WriteLine("Nivel de rendimiento: Inaceptable");
            Console.WriteLine("El bono del empleado es: " + dinero + " euros");
        }
        else if (puntuacion == 0.4)
        {
            Console.WriteLine("Nivel de rendimiento: Aceptable");
            Console.WriteLine("El bono del empleado es: " + dinero + " euros");
        }
        else if (puntuacion >= 0.6)
        {
            Console.WriteLine("Nivel de rendimiento: Meritorio");
            Console.WriteLine("El bono del empleado es: " + dinero + " euros");
        }
        else
        {
            Console.WriteLine("Puntuación inválida. No corresponde a ningún nivel.");
        }
    }
}
