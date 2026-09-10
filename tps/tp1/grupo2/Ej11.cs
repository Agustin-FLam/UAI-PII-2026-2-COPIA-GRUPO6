//Ejercicio 11
//Dada una frase informar la cantidad de caracteres que tiene.

using System;

class trabajo
{
    static void Main(string[] args)
    {
        string frase;

        Console.WriteLine("Ingrese una frase:");
        frase = Console.ReadLine();

        Console.WriteLine("La frase tiene {0} caracteres.", frase.Length);

        Console.ReadKey();
    }
}
