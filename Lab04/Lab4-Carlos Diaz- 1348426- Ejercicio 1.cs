using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo ci = CultureInfo.InvariantCulture;

        
        Console.WriteLine("==== Ejercicio 1: Registro de Nave Espacial ====");
        string modelo = "Explorer-X7";
        int capacidadCarga = 4200;
        float nivelCombustible = 73.5f;
        bool motorSaltoActivo = true;

       
        Console.WriteLine("Modelo: " + modelo + ", Capacidad de carga: " + capacidadCarga +
                          ", Nivel de combustible: " + nivelCombustible + ", ¿Motor de salto activo?: " + motorSaltoActivo);

        
        Console.WriteLine("Ficha técnica:\n - Modelo: " + modelo +
                          "\n - Capacidad de carga: " + capacidadCarga +
                          "\n - Nivel de combustible: " + nivelCombustible +
                          "\n - ¿Motor de salto activo?: " + motorSaltoActivo);

        
        Console.WriteLine("\n==== Ejercicio 2: Expansión de Memoria (Conversión Implícita) ====");
        short sensoresActivos = 128;
        int registroProcesador;
        registroProcesador = sensoresActivos;        
        double precisionTotal = registroProcesador;  
        Console.WriteLine("precisionTotal = " + precisionTotal);

        
        Console.WriteLine("\n==== Ejercicio 3: Ajuste de Energía (Casting Explícito) ====");
        double energiaGenerada = 987.65;
        int energiaLimitada = (int)energiaGenerada; 
        Console.WriteLine("energiaGenerada = " + energiaGenerada + "  |  energiaLimitada = " + energiaLimitada);

        
        Console.WriteLine("\n==== Ejercicio 4: Recepción de Coordenadas (Parse) ====");
        Console.Write("Introduce la distancia al planeta más cercano (ej. \"500\"): ");
        string entradaRadar = Console.ReadLine() ?? "0";
        int distancia;
        try
        {
            distancia = int.Parse(entradaRadar);
        }
        catch
        {
            distancia = 0;
            Console.WriteLine("Entrada no válida. Se usará 0.");
        }
        int distanciaFinal = distancia + 100;
        Console.WriteLine("Distancia con margen de seguridad: " + distanciaFinal);

        
        Console.WriteLine("\n==== Ejercicio 5: Panel de Control (Clase Convert) ====");
        string señalOxigeno = "true";
        bool oxigenoOK = Convert.ToBoolean(señalOxigeno);
        string temperaturaCabina = "22.8";
        double temperatura = Convert.ToDouble(temperaturaCabina, ci);
        Console.WriteLine("Oxígeno activo: " + oxigenoOK + "  |  Temperatura cabina: " + temperatura);

        
        Console.WriteLine("\n==== Ejercicio 6: Reporte de Misión (ToString y Formato) ====");
        double velocidadLuz = 299792.458;
        string velocidadStr = velocidadLuz.ToString(ci);
        string velocidadFormateada = velocidadLuz.ToString("N3", ci); 
        Console.WriteLine("velocidadLuz.ToString() = " + velocidadStr);
        Console.WriteLine("velocidadLuz.ToString(\"N3\") = " + velocidadFormateada);

       
        Console.WriteLine("\n==== Ejercicio 7: Reto Final - Calculadora de Suministros ====");
        Console.Write("Introduce el Precio por Galón de Litio (como texto, ej. \"123.45\"): ");
        string precioTexto = Console.ReadLine() ?? "0";
        double precio;
        try
        {
            precio = Convert.ToDouble(precioTexto, ci);
        }
        catch
        {
            precio = 0;
            Console.WriteLine("Entrada no válida. Se usará 0.");
        }
        double impuesto = precio * 0.12;
        double costoTotal = precio + impuesto;
        int costoTotalEntero = (int)costoTotal; 
        Console.WriteLine("El costo final de suministro es: " + costoTotalEntero);

        Console.WriteLine("\n=== Fin de ejercicios ===");
    }
}
