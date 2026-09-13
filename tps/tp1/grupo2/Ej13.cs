//Ejercicio 13
//Dada una fecha mostrarla en el formato AAAAMMDD.
using System;

class trabajo
{
    static void Main(string[] args)
    {
        DateTime fecha;

        Console.WriteLine("Ingrese una fecha:");
        fecha = DateTime.Parse(Console.ReadLine());

        Console.WriteLine(fecha.ToString("yyyyMMdd"));

        Console.ReadKey();
    }
}
