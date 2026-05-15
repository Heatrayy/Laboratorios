class Program
{
    static void Main()
    {
        // Entrada
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        // Proceso + Salida
        Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio 7!");
      
            int opcion; // ENTRADA: opción del menú
            do
            {
                // ---------------- MENÚ ----------------
                Console.WriteLine("===== MENÚ DE CONVERSIONES =====");
                Console.WriteLine("1. Convertir Celsius a Fahrenheit");
                Console.WriteLine("2. Convertir Fahrenheit a Celsius");
                Console.WriteLine("3. Convertir Kilómetros a Millas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción (1-4): ");

                // Leemos la opción ingresada
                // Nota: asumimos que el usuario ingresa un entero válido
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // ---------------- PROCESO SEGÚN OPCIÓN ELEGIDA ----------------
                switch (opcion)
                {
                    case 1:
                        // Convertir Celsius a Fahrenheit
                        Console.Write("Ingrese la temperatura en Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());

                        double fahrenheit = celsius * 9.0 / 5.0 + 32.0;

                        // SALIDA con 2 decimales
                        Console.WriteLine("{0:F2} °C equivalen a {1:F2} °F", celsius, fahrenheit);
                        Console.WriteLine();
                        break;

                    case 2:
                        // Convertir Fahrenheit a Celsius
                        Console.Write("Ingrese la temperatura en Fahrenheit: ");
                        double f = double.Parse(Console.ReadLine());

                        double c = (f - 32.0) * 5.0 / 9.0;

                        // SALIDA con 2 decimales
                        Console.WriteLine("{0:F2} °F equivalen a {1:F2} °C", f, c);
                        Console.WriteLine();
                        break;

                    case 3:
                        // Convertir Kilómetros a Millas
                        Console.Write("Ingrese la distancia en kilómetros: ");
                        double km = double.Parse(Console.ReadLine());

                        double millas = km * 0.621371;

                        // SALIDA con 2 decimales
                        Console.WriteLine("{0:F2} km equivalen a {1:F2} millas", km, millas);
                        Console.WriteLine();
                        break;

                    case 4:
                        // Opción para salir: no hacemos nada especial aquí,
                        // el ciclo terminará porque la condición del do-while ya no se cumple
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        // Validación: opción inválida
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción entre 1 y 4.");
                        Console.WriteLine();
                        break;
                }

                // El ciclo se repite mientras la opción NO sea 4 (Salir)
            } while (opcion != 4);

            Console.WriteLine("Programa finalizado. Presione cualquier tecla para cerrar...");
            Console.ReadKey();
        }
    }
