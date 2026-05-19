using System;

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;

    public void MostrarInformacion()
    {
        Console.WriteLine("===== INFORMACION DE LA MASCOTA =====");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Especie: " + especie);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Peso: " + peso + " kg");
        Console.WriteLine("Vacunado: " + vacunado);
    }
}

class Program
{
    static void Main()
    {
        Mascota mascota1 = new Mascota();

        mascota1.nombre = "Kawasaki";
        mascota1.especie = "gato";
        mascota1.edad = 4;
        mascota1.peso = 12.5;
        mascota1.vacunado = true;

        mascota1.MostrarInformacion();

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
