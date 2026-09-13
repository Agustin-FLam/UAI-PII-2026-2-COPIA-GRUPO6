using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            string resultado;

            Console.WriteLine("Ingrese una frase:");
            x = Console.ReadLine();

            resultado = x.Substring(x.Length / 2) + x.Substring(0, x.Length / 2);

            Console.WriteLine("Resultado: " + resultado);

            Console.ReadKey();
        }
    }
}
