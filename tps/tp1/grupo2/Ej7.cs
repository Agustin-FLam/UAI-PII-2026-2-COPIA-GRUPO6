//Ejercicio 7
//Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular cuántos bits hay en cualquier combinación de x KBytes. Explique cómo llegó a esa conclusión.

using System;

class trabajo
{
    static void Main(string[] args)
    {
        int kbytes;
        int bits;

        Console.WriteLine("Ingrese la cantidad de KBytes:");
        kbytes = int.Parse(Console.ReadLine());

        bits = kbytes * 1024 * 8;

        Console.WriteLine("La cantidad de bits es: {0}", bits);

        Console.ReadKey();
    }
}
