// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Ingresa tu ID:"); 
int ID = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingresa tu PIN:");
int PIN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingresa tu Token:"); 
int Token = int.Parse(Console.ReadLine() ?? "0");

if (ID == 2026)
{
    Console.WriteLine("Usuario reconocido.");
}
else
{
    Console.WriteLine("Usuario no reconocido.");
}

if (PIN == 1234)
{
    Console.WriteLine("PIN correcto.");
}
else
{
    Console.WriteLine("PIN incorrecto.");
}

if (Token == 777)
{
    Console.WriteLine("Token válido.");
}
else
{
    Console.WriteLine("Token inválido.");
}
Console.WriteLine("¿Deseas activar el modo seguro? (1 para sí, 0 para no):");
int modoseguro = int.Parse(Console.ReadLine() ?? "0");
if ( modoseguro==1) 
    { 
    Console.Write("Modo seguro activado");
       }
            else if (modoseguro == 0)
       {
    Console.Write("Modo seguro desactivado");
        }
if (ID == 2026 && PIN == 1234 && Token == 777)
{
    Console.WriteLine("Acceso total concedido.");
}
else
{
    Console.WriteLine("Acceso denegado.");
}

if (ID == 2026 && PIN == 1234 && Token == 777)
{
    Console.WriteLine("Acceso total concedido.");
}
else
{
    Console.WriteLine("Acceso denegado.");
}




