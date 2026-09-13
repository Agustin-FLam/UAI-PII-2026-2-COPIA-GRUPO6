/******************************************************************************

Dados los datos necesarios de un Cuadrado calcular la superficie.

*******************************************************************************/
int lado, superficie;
Console.WriteLine("Ingrese largo de uno de los lados del cuadrado");
lado = int.Parse(Console.ReadLine());
superficie = lado * lado;
Console.WriteLine("La superficie del cuadrado es: {0}", superficie);
