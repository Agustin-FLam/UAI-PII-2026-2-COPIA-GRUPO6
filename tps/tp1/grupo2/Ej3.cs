using System;

class trabajo
{
    static void Main(string[] args)
    {
        double lado1, lado2, lado3;

        Console.WriteLine("Ingrese el primer lado:");
        lado1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo lado:");
        lado2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer lado:");
        lado3 = double.Parse(Console.ReadLine());

        Console.WriteLine("El perímetro es: {0}", lado1 + lado2 + lado3);

        Console.ReadKey();

    }
}

