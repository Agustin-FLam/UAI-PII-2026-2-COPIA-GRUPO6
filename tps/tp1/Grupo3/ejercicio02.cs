/******************************************************************************

Desarrollar  una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.

*******************************************************************************/

int numero_uno, numero_dos, resultado;

Console.WriteLine("Ingrese el primer numero");
numero_uno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
numero_dos = int.Parse(Console.ReadLine());
resultado = numero_uno - numero_dos;
Console.WriteLine("La distancia entre dos numeros es de: {0} ", resultado);