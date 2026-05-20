using System;
class Parcela
{
    public string TipoSiembra;
    public int MesesNecesarios;
    public int CrecimientoActual;
    public int IngresoCosecha;
    public bool RegadaEsteMes;

    public Parcela()
    {
        TipoSiembra = "Vacia";
        MesesNecesarios = 0;
        CrecimientoActual = 0;
        IngresoCosecha = 0;
        RegadaEsteMes = false;
    }

    public bool EstaVacia()
    {
        return TipoSiembra == "Vacia";
    }

    public void Sembrar(string tipo)
    {
        TipoSiembra = tipo;
        CrecimientoActual = 0;
        RegadaEsteMes = false;

        if (tipo == "Papa")
        {
            MesesNecesarios = 2;
            IngresoCosecha = 450;
        }
        else if (tipo == "Tomate")
        {
            MesesNecesarios = 3;
            IngresoCosecha = 650;
        }
        else if (tipo == "Fresa")
        {
            MesesNecesarios = 4;
            IngresoCosecha = 900;
        }
    }

    public int AvanzarCrecimiento()
    {
        if (EstaVacia())
        {
            return 0;
        }

        if (RegadaEsteMes)
        {
            CrecimientoActual += 2;
        }
        else
        {
            CrecimientoActual += 1;
        }

        RegadaEsteMes = false;

        if (CrecimientoActual >= MesesNecesarios)
        {
            int ingreso = IngresoCosecha;
            Vaciar();
            return ingreso;
        }

        return 0;
    }

    public void Vaciar()
    {
        TipoSiembra = "Vacia";
        MesesNecesarios = 0;
        CrecimientoActual = 0;
        IngresoCosecha = 0;
        RegadaEsteMes = false;
    }
}

class Program
{
    static double dinero;
    static int empleados;
    static double sueldoEmpleado;
    static int mesesRestantes;
    static int mesesSimulados = 0;

    static double totalIngresos = 0;
    static double totalEgresos = 0;

    static int totalRiegos = 0;

    static int siembrasPapa = 0;
    static int siembrasTomate = 0;
    static int siembrasFresa = 0;

    static int cosechasPapa = 0;
    static int cosechasTomate = 0;
    static int cosechasFresa = 0;

    static Parcela[,] granja;

    static void Main(string[] args)
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("   SISTEMA DE GESTION DE GRANJA");
        Console.WriteLine("=======================================");

        ConfigurarSistema();

        bool salir = false;

        while (!salir && mesesRestantes > 0 && dinero > 0)
        {
            MostrarEstadoGeneral();

            Console.WriteLine("\n========== MENU PRINCIPAL ==========");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcelas");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar de mes");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opcion: ");

            int opcion = LeerEnteroEnRango(1, 5);

            if (opcion == 1)
            {
                Sembrar();
            }
            else if (opcion == 2)
            {
                RegarParcela();
            }
            else if (opcion == 3)
            {
                ConsultarParcela();
            }
            else if (opcion == 4)
            {
                AvanzarMes();
            }
            else if (opcion == 5)
            {
                salir = true;
            }
        }

        if (dinero <= 0)
        {
            Console.WriteLine("\nEl dinero llego a Q0 o menos. La simulacion ha terminado.");
        }

        if (mesesRestantes <= 0)
        {
            Console.WriteLine("\nYa no quedan meses por simular. La simulacion ha terminado.");
        }

        MostrarReporteFinal();

        Console.WriteLine("\nPresione cualquier tecla para finalizar...");
        Console.ReadKey();
    }

    static void ConfigurarSistema()
    {
        Console.WriteLine("\nCONFIGURACION INICIAL");

        Console.Write("Ingrese la cantidad de dinero inicial: Q");
        dinero = LeerDoubleMayorQueCero();

        Console.Write("Ingrese el numero de empleados: ");
        empleados = LeerEnteroMayorOIgualACero();

        Console.Write("Ingrese el sueldo por empleado: Q");
        sueldoEmpleado = LeerDoubleMayorOIgualACero();

        Console.Write("Ingrese la cantidad de meses por simular: ");
        mesesRestantes = LeerEnteroMayorQueCero();

        Console.Write("Ingrese la cantidad de filas de parcelas: ");
        int filas = LeerEnteroMayorQueCero();

        Console.Write("Ingrese la cantidad de columnas de parcelas: ");
        int columnas = LeerEnteroMayorQueCero();

        granja = new Parcela[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                granja[i, j] = new Parcela();
            }
        }

        Console.WriteLine("\nSistema configurado correctamente.");
    }

    static void MostrarEstadoGeneral()
    {
        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine("Dinero actual: Q" + dinero);
        Console.WriteLine("Meses restantes: " + mesesRestantes);
        Console.WriteLine("Meses simulados: " + mesesSimulados);
        Console.WriteLine("---------------------------------------");

        MostrarGranja();
    }

    static void MostrarGranja()
    {
        Console.WriteLine("\nEstado de la granja:");
        Console.WriteLine("V = Vacia | P = Papa | T = Tomate | F = Fresa");

        for (int i = 0; i < granja.GetLength(0); i++)
        {
            for (int j = 0; j < granja.GetLength(1); j++)
            {
                string simbolo = "V";

                if (granja[i, j].TipoSiembra == "Papa")
                {
                    simbolo = "P";
                }
                else if (granja[i, j].TipoSiembra == "Tomate")
                {
                    simbolo = "T";
                }
                else if (granja[i, j].TipoSiembra == "Fresa")
                {
                    simbolo = "F";
                }

                Console.Write("[" + simbolo + "] ");
            }

            Console.WriteLine();
        }
    }

    static void Sembrar()
    {
        Console.WriteLine("\n--- SEMBRAR ---");

        int fila = PedirFila();
        int columna = PedirColumna();

        if (!granja[fila, columna].EstaVacia())
        {
            Console.WriteLine("Error: esta parcela ya tiene una siembra.");
            return;
        }

        Console.WriteLine("\nSeleccione el tipo de siembra:");
        Console.WriteLine("1. Papa   - Crece en 2 meses - Ingreso Q450");
        Console.WriteLine("2. Tomate - Crece en 3 meses - Ingreso Q650");
        Console.WriteLine("3. Fresa  - Crece en 4 meses - Ingreso Q900");
        Console.Write("Opcion: ");

        int opcion = LeerEnteroEnRango(1, 3);

        if (opcion == 1)
        {
            granja[fila, columna].Sembrar("Papa");
            siembrasPapa++;
            Console.WriteLine("Se sembro Papa correctamente.");
        }
        else if (opcion == 2)
        {
            granja[fila, columna].Sembrar("Tomate");
            siembrasTomate++;
            Console.WriteLine("Se sembro Tomate correctamente.");
        }
        else if (opcion == 3)
        {
            granja[fila, columna].Sembrar("Fresa");
            siembrasFresa++;
            Console.WriteLine("Se sembro Fresa correctamente.");
        }
    }

    static void RegarParcela()
    {
        Console.WriteLine("\n--- REGAR PARCELA ---");

        int fila = PedirFila();
        int columna = PedirColumna();

        Parcela parcela = granja[fila, columna];

        if (parcela.EstaVacia())
        {
            Console.WriteLine("Error: no se puede regar una parcela vacia.");
            return;
        }

        if (parcela.RegadaEsteMes)
        {
            Console.WriteLine("Error: esta parcela ya fue regada este mes.");
            return;
        }

        if (dinero < 40)
        {
            Console.WriteLine("Error: no tiene suficiente dinero para regar. Costo: Q40.");
            return;
        }

        parcela.RegadaEsteMes = true;
        dinero -= 40;
        totalEgresos += 40;
        totalRiegos++;

        Console.WriteLine("Parcela regada correctamente. Se descontaron Q40.");
    }

    static void ConsultarParcela()
    {
        Console.WriteLine("\n--- CONSULTAR PARCELA ---");

        int fila = PedirFila();
        int columna = PedirColumna();

        Parcela parcela = granja[fila, columna];

        if (parcela.EstaVacia())
        {
            Console.WriteLine("La parcela esta vacia y disponible para siembra.");
        }
        else
        {
            Console.WriteLine("Tipo de cultivo: " + parcela.TipoSiembra);
            Console.WriteLine("Crecimiento: " + parcela.CrecimientoActual + " / " + parcela.MesesNecesarios + " meses");

            if (parcela.RegadaEsteMes)
            {
                Console.WriteLine("Regada este mes: Si");
            }
            else
            {
                Console.WriteLine("Regada este mes: No");
            }
        }
    }

    static void AvanzarMes()
    {
        Console.WriteLine("\n--- AVANZAR DE MES ---");

        double pagoEmpleados = empleados * sueldoEmpleado;

        dinero -= pagoEmpleados;
        totalEgresos += pagoEmpleados;

        Console.WriteLine("Pago a empleados realizado: Q" + pagoEmpleados);

        mesesRestantes--;
        mesesSimulados++;

        for (int i = 0; i < granja.GetLength(0); i++)
        {
            for (int j = 0; j < granja.GetLength(1); j++)
            {
                Parcela parcela = granja[i, j];

                if (!parcela.EstaVacia())
                {
                    string tipoAntes = parcela.TipoSiembra;
                    int crecimientoAntes = parcela.CrecimientoActual;
                    bool estabaRegada = parcela.RegadaEsteMes;

                    int ingreso = parcela.AvanzarCrecimiento();

                    if (ingreso > 0)
                    {
                        dinero += ingreso;
                        totalIngresos += ingreso;

                        if (tipoAntes == "Papa")
                        {
                            cosechasPapa++;
                        }
                        else if (tipoAntes == "Tomate")
                        {
                            cosechasTomate++;
                        }
                        else if (tipoAntes == "Fresa")
                        {
                            cosechasFresa++;
                        }

                        Console.WriteLine("Parcela [" + (i + 1) + "," + (j + 1) + "] cosechada.");
                        Console.WriteLine("Cultivo: " + tipoAntes + " | Ingreso generado: Q" + ingreso);
                    }
                    else
                    {
                        Console.WriteLine("Parcela [" + (i + 1) + "," + (j + 1) + "] avanzo su crecimiento.");

                        if (estabaRegada)
                        {
                            Console.WriteLine("Como fue regada, aumento de " + crecimientoAntes + " a " + parcela.CrecimientoActual + " meses.");
                        }
                        else
                        {
                            Console.WriteLine("Aumento de " + crecimientoAntes + " a " + parcela.CrecimientoActual + " meses.");
                        }
                    }
                }
            }
        }

        Console.WriteLine("Mes avanzado correctamente.");
    }

    static void MostrarReporteFinal()
    {
        Console.WriteLine("\n=======================================");
        Console.WriteLine("            REPORTE FINAL");
        Console.WriteLine("=======================================");

        Console.WriteLine("Dinero final: Q" + dinero);
        Console.WriteLine("Total de ingresos: Q" + totalIngresos);
        Console.WriteLine("Total de egresos: Q" + totalEgresos);
        Console.WriteLine("Meses simulados: " + mesesSimulados);

        Console.WriteLine("\nCantidad de siembras realizadas:");
        Console.WriteLine("Papa: " + siembrasPapa);
        Console.WriteLine("Tomate: " + siembrasTomate);
        Console.WriteLine("Fresa: " + siembrasFresa);

        Console.WriteLine("\nCantidad de cosechas realizadas:");
        Console.WriteLine("Papa: " + cosechasPapa);
        Console.WriteLine("Tomate: " + cosechasTomate);
        Console.WriteLine("Fresa: " + cosechasFresa);

        Console.WriteLine("\nCantidad total de riegos realizados: " + totalRiegos);

        int vacias = ContarParcelasVacias();
        Console.WriteLine("Cantidad de parcelas vacias al finalizar: " + vacias);

        Console.WriteLine("\nParcelas sembradas actualmente al finalizar:");
        Console.WriteLine("Papa: " + ContarParcelasPorTipo("Papa"));
        Console.WriteLine("Tomate: " + ContarParcelasPorTipo("Tomate"));
        Console.WriteLine("Fresa: " + ContarParcelasPorTipo("Fresa"));
    }

    static int ContarParcelasVacias()
    {
        int contador = 0;

        for (int i = 0; i < granja.GetLength(0); i++)
        {
            for (int j = 0; j < granja.GetLength(1); j++)
            {
                if (granja[i, j].EstaVacia())
                {
                    contador++;
                }
            }
        }

        return contador;
    }

    static int ContarParcelasPorTipo(string tipo)
    {
        int contador = 0;

        for (int i = 0; i < granja.GetLength(0); i++)
        {
            for (int j = 0; j < granja.GetLength(1); j++)
            {
                if (granja[i, j].TipoSiembra == tipo)
                {
                    contador++;
                }
            }
        }

        return contador;
    }

    static int PedirFila()
    {
        Console.Write("Ingrese la fila, desde 1 hasta " + granja.GetLength(0) + ": ");
        int fila = LeerEnteroEnRango(1, granja.GetLength(0));
        return fila - 1;
    }

    static int PedirColumna()
    {
        Console.Write("Ingrese la columna, desde 1 hasta " + granja.GetLength(1) + ": ");
        int columna = LeerEnteroEnRango(1, granja.GetLength(1));
        return columna - 1;
    }

    static int LeerEnteroEnRango(int minimo, int maximo)
    {
        int numero;
        bool valido = false;

        do
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero >= minimo && numero <= maximo)
                {
                    valido = true;
                }
                else
                {
                    Console.Write("Error. Ingrese un numero entre " + minimo + " y " + maximo + ": ");
                }
            }
            else
            {
                Console.Write("Error. Ingrese un numero entero valido: ");
            }

        } while (!valido);

        return numero;
    }

    static int LeerEnteroMayorQueCero()
    {
        int numero;
        bool valido = false;

        do
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.Write("Error. Ingrese un numero mayor que 0: ");
                }
            }
            else
            {
                Console.Write("Error. Ingrese un numero entero valido: ");
            }

        } while (!valido);

        return numero;
    }

    static int LeerEnteroMayorOIgualACero()
    {
        int numero;
        bool valido = false;

        do
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero >= 0)
                {
                    valido = true;
                }
                else
                {
                    Console.Write("Error. Ingrese un numero mayor o igual a 0: ");
                }
            }
            else
            {
                Console.Write("Error. Ingrese un numero entero valido: ");
            }

        } while (!valido);

        return numero;
    }

    static double LeerDoubleMayorQueCero()
    {
        double numero;
        bool valido = false;

        do
        {
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero))
            {
                if (numero > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.Write("Error. Ingrese un numero mayor que 0: ");
                }
            }
            else
            {
                Console.Write("Error. Ingrese un numero valido: ");
            }

        } while (!valido);

        return numero;
    }

    static double LeerDoubleMayorOIgualACero()
    {
        double numero;
        bool valido = false;

        do
        {
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero))
            {
                if (numero >= 0)
                {
                    valido = true;
                }
                else
                {
                    Console.Write("Error. Ingrese un numero mayor o igual a 0: ");
                }
            }
            else
            {
                Console.Write("Error. Ingrese un numero valido: ");
            }

        } while (!valido);

        return numero;
    }
}
