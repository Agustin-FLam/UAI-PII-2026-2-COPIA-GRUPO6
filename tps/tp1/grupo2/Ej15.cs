//Ejercicio 15
//Informar cuantos días faltan para el 25/12/2020.
using System;

class trabajo
{
    static void Main(string[] args)
    {
        DateTime fechaActual = DateTime.Now;
        DateTime navidad = new DateTime(2020, 12, 25);

        TimeSpan diferencia = navidad - fechaActual;

        Console.WriteLine("Faltan {0} días para el 25/12/2020.", diferencia.Days);

        Console.ReadKey();
    }
}
