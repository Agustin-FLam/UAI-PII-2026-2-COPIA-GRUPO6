/******************************************************************************

Dados los datos necesarios de un Rectángulo calcular la superficie.

*******************************************************************************/
int lado_uno, lado_dos, superficie;
Console.WriteLine("Ingrese el primer lado");
lado_uno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo lado");
lado_dos = int.Parse(Console.ReadLine());
superficie = lado_uno * lado_dos;
Console.WriteLine("La superficie es de {0}", superficie);