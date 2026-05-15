using System;

class Ejercicio1
{
    static void Main()
    {
        Console.WriteLine("Ingresa un número del 1 al 5 según el tipo de vehículo:");
        Console.WriteLine("1. Bicicleta");
        Console.WriteLine("2. Motocicleta");
        Console.WriteLine("3. Auto");
        Console.WriteLine("4. Camión");
        Console.WriteLine("5. Autobús");

        int tipoVehiculo = int.Parse(Console.ReadLine());

        switch (tipoVehiculo)
        {
            case 1:
                Console.WriteLine("Bicicleta → Clasificación: No motorizado");
                break;
            case 2:
                Console.WriteLine("Motocicleta → Clasificación: Ligero");
                break;
            case 3:
                Console.WriteLine("Auto → Clasificación: Mediano");
                break;
            case 4:
                Console.WriteLine("Camión → Clasificación: Pesado");
                break;
            case 5:
                Console.WriteLine("Autobús → Clasificación: Transporte público");
                break;
            default:
                Console.WriteLine("Error: número fuera de rango. Debe ser del 1 al 5.");
                break;
        }
    }
}
