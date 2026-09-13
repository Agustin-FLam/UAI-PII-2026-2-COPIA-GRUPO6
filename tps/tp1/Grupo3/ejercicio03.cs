/******************************************************************************

Dados los lados de un triangulo calcular el perímetro.

*******************************************************************************/
int lado_uno, lado_dos, lado_tres, perimetro;
Console.WriteLine("Ingrese el Lado 1");
lado_uno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Lado 2");
lado_dos = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Lado 3");
lado_tres = int.Parse(Console.ReadLine());
perimetro = lado_uno + lado_dos + lado_tres;
Console.WriteLine("El perimetro del triangulo es de {0}", perimetro);