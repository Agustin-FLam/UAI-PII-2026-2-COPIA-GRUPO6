//Ejercicio 4
//Dados los datos necesarios de un Cuadrado calcular lasuperficie.


using System;

class trabajo
{
    static void Main(string[] args)
    {
        double lado;

        Console.WriteLine("Ingrese el lado del cuadrado:");
        lado = double.Parse(Console.ReadLine());

        Console.WriteLine("La superficie es: {0}", lado * lado);

        Console.ReadKey();

    }
}

