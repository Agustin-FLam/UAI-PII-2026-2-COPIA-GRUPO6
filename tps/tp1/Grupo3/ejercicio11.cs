using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Ej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("Ingrese una frase:");
            frase = Console.ReadLine();

            Console.WriteLine("La frase tiene " + frase.Length + " caracteres.");

            Console.ReadKey();
        }
    }
}
