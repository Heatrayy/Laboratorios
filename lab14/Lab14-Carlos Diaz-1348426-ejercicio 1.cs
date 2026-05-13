using System;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 1967, true);
            Libro libro2 = new Libro("El Principito", "Antoine de Saint-Exupéry", 1943, true);

            Console.WriteLine("INFORMACIÓN INICIAL\n");
            libro1.MostrarInformacion();
            libro2.MostrarInformacion();

            Console.WriteLine("PRESTAR LIBRO 1\n");
            libro1.PrestarLibro();
            libro1.MostrarInformacion();

            Console.WriteLine("DEVOLVER LIBRO 1\n");
            libro1.DevolverLibro();
            libro1.MostrarInformacion();

            Console.ReadKey();
        }
    }

    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public bool Disponible { get; set; }

        public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            Disponible = disponible;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año: {AnioPublicacion}");
            Console.WriteLine($"Disponible: {Disponible}\n");
        }

        public void PrestarLibro()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine("Libro prestado correctamente.\n");
            }
            else
            {
                Console.WriteLine("El libro no está disponible.\n");
            }
        }

        public void DevolverLibro()
        {
            Disponible = true;
            Console.WriteLine("Libro devuelto correctamente.\n");
        }
    }
}
