using System;

class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;

    public void MostrarInformacion()
    {
        Console.WriteLine("Codigo: " + codigo);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: Q" + precio);
        Console.WriteLine("Stock: " + stock);
        Console.WriteLine("Disponible: " + disponible);
    }
}

class Program
{
    static void Main()
    {
        Producto producto1 = new Producto();

        producto1.codigo = "P001";
        producto1.nombre = "Cuaderno";
        producto1.precio = 15.50;
        producto1.stock = 25;
        producto1.disponible = true;

        Producto producto2 = new Producto();

        producto2.codigo = "P002";
        producto2.nombre = "Lapicero";
        producto2.precio = 3.75;
        producto2.stock = 100;
        producto2.disponible = true;

        Console.WriteLine("===== INFORMACION DEL PRODUCTO 1 =====");
        producto1.MostrarInformacion();

        Console.WriteLine();

        Console.WriteLine("===== INFORMACION DEL PRODUCTO 2 =====");
        producto2.MostrarInformacion();

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
