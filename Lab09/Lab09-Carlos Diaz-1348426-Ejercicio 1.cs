class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 9 - Procedimientos");
            Console.WriteLine("------------------------------");
            Console.Write("Ingrese su nombre de usuario: ");
            string nombre = Console.ReadLine();
            MostrarSaludo(nombre);
            MostrarInfoCurso();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
        static void MostrarSaludo(string nombreUsuario)
        {
            Console.WriteLine("¡Hola, {nombreUsuario}! Bienvenido al laboratorio de procedimientos.");
        }
        static void MostrarInfoCurso()
        {
            Console.WriteLine("Curso: Introducción a la Programación en C#");
            Console.WriteLine("Número de laboratorio: 9");
        }
    }
