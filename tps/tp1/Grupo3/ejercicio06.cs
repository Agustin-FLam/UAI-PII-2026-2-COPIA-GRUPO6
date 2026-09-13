/******************************************************************************

Si la circunferencia de un círculo es pi * Diámetro, 
desarrollar una aplicación que dada la circunferencia calcule el diámetro.

*******************************************************************************/
float diametro, resultado;
Console.WriteLine("Ingrese el diametro del circulo");
diametro = float.Parse(Console.ReadLine());
resultado = diametro * 3.14f;
Console.WriteLine("La circunferencia del circulo es: {0}", resultado);