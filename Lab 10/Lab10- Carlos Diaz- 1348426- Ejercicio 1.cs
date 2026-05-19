using System;

class Program
{
    static void Main()
    {
        // Estructura base solicitada
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        // EJERCICIO 1
        Console.WriteLine("EJERCICIO 1: Suma de dígitos");
        int numero1 = 1234;
        int numero2 = 905;

        Console.WriteLine("Entrada: " + numero1 + " → Salida: " + SumarDigitos(numero1));
        Console.WriteLine("Entrada: " + numero2 + " → Salida: " + SumarDigitos(numero2));
        Console.WriteLine();

        // EJERCICIO 2
        Console.WriteLine("EJERCICIO 2: Parámetro por referencia");
        int n = 6;
        Console.WriteLine("Antes: N = " + n);
        string mensaje = ElevarAlCuadrado(ref n);
        Console.WriteLine(mensaje);
        Console.WriteLine("Después: N = " + n);
        Console.WriteLine();

        // EJERCICIO 3
        Console.WriteLine("EJERCICIO 3: Descuento");
        double precio = 200;
        double descuento = 0.25;

        double montoDescontado = AplicarDescuento(descuento, ref precio);
        Console.WriteLine("Precio final = " + precio + ", Descuento = " + montoDescontado);
        Console.WriteLine();

        // EJERCICIO 4
        Console.WriteLine("EJERCICIO 4: Videojuego");
        int energiaJugador = 10;

        Console.WriteLine("Energía inicial: " + energiaJugador);

        consumirEnergia(ref energiaJugador);
        Console.WriteLine("Después de consumir: " + energiaJugador);

        recargarEnergia(ref energiaJugador);
        Console.WriteLine("Después de recargar: " + energiaJugador);

        Console.WriteLine("Estado: " + obtenerEstado(energiaJugador));
        Console.WriteLine("Rendimiento: " + calcularRendimiento(energiaJugador));
    }

    // =========================
    // EJERCICIO 1
    static int SumarDigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }

        return suma;
    }

    // =========================
    // EJERCICIO 2
    // =========================
    static string ElevarAlCuadrado(ref int numero)
    {
        numero = numero * numero;
        return "La operación fue realizada correctamente.";
    }

    // =========================
    // EJERCICIO 3
    static double AplicarDescuento(double porcentaje, ref double precio)
    {
        double descuento = precio * porcentaje;
        precio -= descuento;
        return descuento;
    }

    // =========================
    // EJERCICIO 4
    static int consumirEnergia(ref int energia)
    {
        energia -= 4;
        if (energia < 0)
            energia = 0;

        return energia;
    }

    static int recargarEnergia(ref int energia)
    {
        energia += 6;
        if (energia > 20)
            energia = 20;

        return energia;
    }

    static string obtenerEstado(int energia)
    {
        if (energia >= 15)
            return "Alta";
        else if (energia >= 8)
            return "Media";
        else
            return "Baja";
    }

    static string calcularRendimiento(int energia)
    {
        if (energia == 20)
            return "S";
        else if (energia >= 15)
            return "A";
        else if (energia >= 8)
            return "B";
        else
            return "C";
    }
}
