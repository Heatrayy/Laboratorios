using System;

using System;

class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;

    public void MostrarInformacion()
    {
        Console.WriteLine("===== INFORMACION DE LA PERSONA =====");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Altura: " + altura + " metros");
        Console.WriteLine("Estudiante: " + estudiante);
    }
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona();

        persona1.nombre = "Carlos Diaz";
        persona1.edad = 18;
        persona1.altura = 1.70;
        persona1.estudiante = true;

        persona1.MostrarInformacion();

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
