/* Ejercicio Nº5 Dados los datos necesarios de un Rectángulo calcular la superficie.*/

using System;
namespace Proyecto
{
    class EjercicioNº5
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la base de un rectangulo: ");
            double baseRectangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingrese la altura del rectangulo");
            double altura = Convert.ToDouble(Console.ReadLine());

            double superficie = baseRectangulo * altura;

            Console.WriteLine($"La superficie del rectangulo es: {superficie}");
        }
    }

}