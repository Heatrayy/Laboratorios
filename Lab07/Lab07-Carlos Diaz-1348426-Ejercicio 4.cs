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
            const int PIN_CORRECTO = 1234; // PIN válido
            int intentos = 0;              // Contador de intentos realizados
            int pinIngresado;              // PIN que ingresa el usuario

            // PROCESO: repetir solicitud de PIN hasta acertar o agotar intentos
            do
            {
                Console.Write("Ingrese su PIN: ");
                pinIngresado = int.Parse(Console.ReadLine());
                intentos++; // Incrementamos el número de intentos usados

                if (pinIngresado == PIN_CORRECTO)
                {
                    Console.WriteLine("Acceso concedido");
                    break; // Termina el ciclo porque el acceso fue correcto
                }
                else
                {
                    Console.WriteLine("PIN incorrecto");
                }

            } while (intentos < 3); // Se repite mientras no supere los 3 intentos

            // Si se usaron los 3 intentos y nunca acertó, se bloquea la cuenta

        }
    }
