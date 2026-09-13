//Ejercicio 6
//Si la circunferencia de un círculo es pi * Diámetro, desarrollar una aplicación que dada la circunferencia calcule el diámetro.
using System;

class trabajo
{
    static void Main(string[] args)
    {
        double circunferencia;
        double diametro;

        Console.WriteLine("Ingrese la circunferencia:");
        circunferencia = double.Parse(Console.ReadLine());

        diametro = circunferencia / Math.PI;

        Console.WriteLine("El diámetro es: {0}", diametro);

        Console.ReadKey();

    }
}
