using System;
class Program
{
    static void Main()
    {

        int nota;
        int aprobados = 0;
        int reprobados = 0;
        int suma = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la nota del estudiante " + i + ": ");
            nota = int.Parse(Console.ReadLine());
            suma += nota;
            if (nota >= 61)
            {
                Console.WriteLine("Aprobado");
                aprobados++;

            }
            else
            {
                Console.WriteLine("Reprobado");
                reprobados++;
            }
        }
        double promedio = suma / 10.0;
        Console.WriteLine("RESULTADOS");
        Console.WriteLine("Promedio de la clase: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }
}
