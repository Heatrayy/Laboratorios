using System;
namespace L14
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota("KAWIWI", "Perro", 3, false);
            Mascota mascota2 = new Mascota("KABEZUKO", "Gato", 2, false);

            Console.WriteLine("INFORMACIÓN DE MASCOTAS\n");
            mascota1.MostrarInformacion();
            mascota2.MostrarInformacion();

            Console.WriteLine("VACUNAR A KAWIWI\n");
            mascota1.Vacunar();
            mascota1.MostrarInformacion();

            Console.WriteLine("KABEZUKO CUMPLE AÑOS\n");
            mascota2.CumplirAnios();
            mascota2.MostrarInformacion();

            Console.ReadKey();
        }
    }

    class Mascota
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }
        public bool Vacunado { get; set; }

        public Mascota(string nombre, string especie, int edad, bool vacunado)
        {
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Vacunado = vacunado;
        }
