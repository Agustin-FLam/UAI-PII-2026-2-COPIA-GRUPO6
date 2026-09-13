//Ejercicio 5
//Dados los datos necesarios de un Rectángulo calcular lasuperficie.
using System;

class trabajo
{
    static void Main(string[] args)
    {
        double baseRectangulo, altura;

        Console.WriteLine("Ingrese la base:");
        baseRectangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura:");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("La superficie es: {0}", baseRectangulo * altura);

        Console.ReadKey();

    }
}
