//Ejercicio 10
//Dada una frase cualquiera llamada x, mostrar como resultado una frase formada por la segunda mitad de x más la primer mitad de x. (usar el método substring)
using System;

class trabajo
{
    static void Main(string[] args)
    {
        string x;
        int mitad;

        Console.WriteLine("Ingrese una frase:");
        x = Console.ReadLine();

        mitad = x.Length / 2;

        Console.WriteLine(x.Substring(mitad) + x.Substring(0, mitad));

        Console.ReadKey();
    }
}

a