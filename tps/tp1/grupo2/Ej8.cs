//Ejercicio 8
//Calcular el factorial de 6.


using System;

class trabajo
{
    static void Main(string[] args)
    {
        int factorial = 1;

        for (int i = 1; i <= 6; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("El factorial de 6 es: {0}", factorial);

        Console.ReadKey();
    }
}
