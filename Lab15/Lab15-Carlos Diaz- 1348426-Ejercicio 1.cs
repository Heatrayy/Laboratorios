using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== LABORATORIO 15 ===");

        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
        Ejercicio5();

        Console.WriteLine("\n--- Fin del laboratorio ---");
    }

    // EJERCICIO 1 – ERRORES DE SINTAXIS
    static void Ejercicio1()
    {
        Console.WriteLine("\n--- Ejercicio 1 ---");

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada: Se agregó punto y coma al final de using System;
        // Explicación: En C# todas las instrucciones deben finalizar con punto y coma.

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada: Se agregaron puntos y coma a las declaraciones de variables.
        // Explicación: Las variables deben cerrarse correctamente para que el código compile.

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada: Se agregó punto y coma después de int.Parse().
        // Explicación: Sin punto y coma el compilador marca error.

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada: Se cerró correctamente el bloque if con llave antes del else.
        // Explicación: El else debe corresponder a un if correctamente cerrado.

        string nombre;
        int edad;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }

        // Pruebas:
        // Edad 20 → Mayor de edad
        // Edad 15 → Menor de edad
    }

    // EJERCICIO 2 – ERRORES LÓGICOS
    static void Ejercicio2()
    {
        Console.WriteLine("\n--- Ejercicio 2 ---");

        double nota1, nota2, nota3, promedio;

        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());

        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada: Se agregaron paréntesis para sumar antes de dividir.
        // Explicación: Sin paréntesis, solo se dividía nota3 entre 3.

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio es: " + promedio);

        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada: Se cambió > 61 por >= 61.
        // Explicación: El enunciado indica que 61 también aprueba.

        if (promedio >= 61)
        {
            Console.WriteLine("El estudiante aprobó");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó");
        }

        // Casos de prueba:
        // 60,60,60 → 60 → Reprobó
        // 61,61,61 → 61 → Aprobó
        // 80,70,90 → 80 → Aprobó
    }

    // EJERCICIO 3 – ERRORES DE EJECUCIÓN (ARREGLOS)
    static void Ejercicio3()
    {
        Console.WriteLine("\n--- Ejercicio 3 ---");

        int[] numeros = new int[5];
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            bool valido = false;
            while (!valido)
            {
                Console.WriteLine("Ingrese un número:");

                if (int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                }
            }
        }

        // Error encontrado:
        // Tipo de error: ejecución
        // Corrección realizada: Se cambió i <= 5 por i < numeros.Length.
        // Explicación: El arreglo solo tiene posiciones de 0 a 4.

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine("La suma total es: " + suma);

        // Pruebas:
        // 1,2,3,4,5 → 15
        // Texto → vuelve a pedir dato
    }

    // EJERCICIO 4 – DEPURACIÓN CON MÉTODOS
    static void Ejercicio4()
    {
        Console.WriteLine("\n--- Ejercicio 4 ---");

        double baseRectangulo, alturaRectangulo;

        baseRectangulo = LeerDoublePositivo("Ingrese la base del rectángulo:");
        alturaRectangulo = LeerDoublePositivo("Ingrese la altura del rectángulo:");

        double area = CalcularArea(baseRectangulo, alturaRectangulo);

        Console.WriteLine("El área es: " + area);

        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada: Se cambió > 100 por >= 100.
        // Explicación: Un área de 100 debe considerarse grande.

        if (area >= 100)
        {
            Console.WriteLine("El área es grande");
        }
        else
        {
            Console.WriteLine("El área es pequeña");
        }

        // Casos de prueba:
        // 10x10 → 100 → Grande
        // 5x8 → 40 → Pequeña
        // -5 → se rechaza
    }

    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada: Se cambió suma por multiplicación.
        // Explicación: El área se calcula multiplicando base por altura.

        return baseRectangulo * alturaRectangulo;
    }

    static double LeerDoublePositivo(string mensaje)
    {
        double valor = 0; // inicializar evita CS0165
        bool valido = false;

        while (!valido)
        {
            Console.WriteLine(mensaje);
            if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("Valor inválido. Debe ser mayor a cero.");
            }
        }
        return valor;
    }
    // EJERCICIO 5 – ANÁLISIS DE SOLUCIÓN IA
    static void Ejercicio5()
    {
        Console.WriteLine("\n--- Ejercicio 5 ---");

        int[] edades = new int[5];
        int suma = 0;
        int mayores = 0;

        for (int i = 0; i < edades.Length; i++)
        {
            bool valido = false;
            while (!valido)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");

                if (int.TryParse(Console.ReadLine(), out edades[i]) && edades[i] >= 0)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Intente de nuevo.");
                }
            }

            suma += edades[i];

            if (edades[i] >= 18)
            {
                mayores++;
            }
        }

        double promedio = (double)suma / edades.Length;

        Console.WriteLine("El promedio de edades es: " + promedio);
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);

        // Análisis de la solución generada por IA:
        // Error 1: Uso incorrecto de índices (1 a 5).
        // Error 2: No consideraba 18 como mayor de edad.
        // Error 3: Promedio calculado sin decimales.
        // Limitación encontrada: No validaba entradas inválidas.
        // Importancia de la validación humana: La IA no prueba ni ejecuta el código.
    }
}

/*
¿Por qué una solución generada por Inteligencia Artificial debe ser revisada, probada y validada por una persona antes de considerarse correcta?
La Inteligencia Artificial puede generar código funcional, pero no garantiza que cumpla todas las reglas del problema.
Puede cometer errores lógicos, de ejecución o asumir condiciones incorrectas.
No prueba el programa con datos reales ni considera todos los casos límite.
El programador humano es responsable de validar, depurar y garantizar la calidad del software.
La IA es una herramienta de apoyo, no va a remplazar al ingeniero en sistemas ya que el controla la IA el le da ordenes a la IA de lo que tiene que programar
*/
