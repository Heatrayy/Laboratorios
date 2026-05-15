using System;
class Program
{
    static void Main()
    {
        int opcion;
        double totalVentas = 0;
        int clientesAtendidos = 0;
        double monto;

        do
        {
            Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
            Console.WriteLine("1) Registrar compra");
            Console.WriteLine("2) Mostrar total de ventas");
            Console.WriteLine("3) Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4) Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el monto de la compra: ");
                    monto = double.Parse(Console.ReadLine());
                    totalVentas += monto;
                    clientesAtendidos++;
                    Console.WriteLine("Compra registrada correctamente.");
                    break;

                case 2:
                    Console.WriteLine("Total de ventas del día: Q" + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Cantidad de clientes atendidos: " + clientesAtendidos);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 4);
    }
}
