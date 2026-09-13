//Ejercicio 9
//Dadas dos frases concatenarlas y mostrar el resultado. 

using System;

class trabajo
{
    static void Main(string[] args)
    {
        string frase1;
        string frase2;

        Console.WriteLine("Ingrese la primera frase:");
        frase1 = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda frase:");
        frase2 = Console.ReadLine();

        Console.WriteLine("Resultado: {0} {1}", frase1, frase2);

        Console.ReadKey();
    }
}
