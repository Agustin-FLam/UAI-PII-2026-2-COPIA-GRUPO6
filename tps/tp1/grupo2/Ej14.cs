//Ejercicio 14
//Dadas dos fechas calcular la diferencia en días entre una y la otra.


using System;

class trabajo
{
    static void Main(string[] args)
    {
        DateTime fecha1;
        DateTime fecha2;

        Console.WriteLine("Ingrese la primera fecha:");
        fecha1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda fecha:");
        fecha2 = DateTime.Parse(Console.ReadLine());

        TimeSpan diferencia = fecha2 - fecha1;

        Console.WriteLine("La diferencia es de {0} días.", Math.Abs(diferencia.Days));

        Console.ReadKey();
    }
}
