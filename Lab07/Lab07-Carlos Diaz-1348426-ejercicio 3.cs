using System;

class Program
{
    static void Main()
    {
        // Entrada
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Proceso + Salida
        Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio 7!");
            // Creamos el generador de números aleatorios
            Random random = new Random();

            // ENTRADA: número secreto generado por la computadora (entre 1 y 100)
            int numeroSecreto = random.Next(1, 101); // 1 incluido, 101 no incluido

            int intento;           // Número que ingresa el usuario
            int intentos = 0;      // Contador de intentos válidos

            Console.WriteLine("=== JUEGO: ADIVINA EL NÚMERO ===");
            Console.WriteLine("He pensado un número entre 1 y 100. ¡Intenta adivinarlo!");

            // Usamos DO-WHILE para que el usuario intente al menos una vez
            do
            {
                Console.Write("Ingresa tu intento (1-100): ");
                // Leemos el valor del intento
                intento = int.Parse(Console.ReadLine());

                // -------- VALIDACIÓN DEL RANGO (1 a 100) --------
                if (intento < 1 || intento > 100)
                {
                    // Si está fuera del rango, no contamos el intento
                    Console.WriteLine("Número fuera de rango. Debe estar entre 1 y 100. Intente de nuevo.\n");
                    continue; // Volvemos al inicio del ciclo sin incrementar intentos
                }

                // Si el número está en rango, ahora sí contamos el intento
                intentos++;

                // -------- COMPARACIÓN CON EL NÚMERO SECRETO --------
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Más alto.\n");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Más bajo.\n");
                }
                else
                {
                    // intento == numeroSecreto
                    Console.WriteLine("\n¡Correcto! El número era {0}.", numeroSecreto);
                    Console.WriteLine("Adivinaste en {0} intento(s).", intentos);
                }

            } while (intento != numeroSecreto); // El ciclo se repite mientras no se adivine

            Console.WriteLine("\nFin del juego. Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
