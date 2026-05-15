using System;

class Ejercicio2
{
    static void Main()
    {
        Console.WriteLine("Banco Industrial - Cálculo de nuevo límite de crédito");

        Console.WriteLine("Ingrese su tipo de tarjeta:");
        Console.WriteLine("1. Tarjeta tipo 1");
        Console.WriteLine("2. Tarjeta tipo 2");
        Console.WriteLine("3. Tarjeta tipo 3");
        Console.WriteLine("Cualquier otro número: otro tipo de tarjeta");
        int tipoTarjeta = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el límite de crédito actual de su tarjeta:");
        double limiteActual = double.Parse(Console.ReadLine());

        double nuevoLimite;

        switch (tipoTarjeta)
        {
            case 1:
                nuevoLimite = limiteActual + (limiteActual * 0.25);
                Console.WriteLine("Tipo 1 → aumento del 25%.");
                break;
            case 2:
                nuevoLimite = limiteActual + (limiteActual * 0.35);
                Console.WriteLine("Tipo 2 → aumento del 35%.");
                break;
            case 3:
                nuevoLimite = limiteActual + (limiteActual * 0.40);
                Console.WriteLine("Tipo 3 → aumento del 40%.");
                break;
            default:
                nuevoLimite = limiteActual + (limiteActual * 0.50);
                Console.WriteLine("Otro tipo de tarjeta → aumento del 50%.");
                break;
        }

        Console.WriteLine("Su nuevo límite de crédito es: " + nuevoLimite);
    }
}﻿
