/*Ejercicio 1
Dados dos valores ingresados por teclado mostrar la suma de ambos.*/

int numero1, numero2, resultado;

Console.WriteLine("Ingrese un numero");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 + numero2;

Console.WriteLine("El resultado de la suma de ambos numeros es: {0}", resultado);