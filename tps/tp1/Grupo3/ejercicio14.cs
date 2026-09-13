//Ejercicio 14
//PROGRAMACIÓN Y ESTRUCTURAS DE DATOS / Pág.4
//Dadas dos fechas calcular la diferencia en días entre una y la otra.

DateTime fecha1, fecha2;
TimeSpan diferencia;

Console.WriteLine("Ingrese la primera fecha (dd/mm/aaaa):");
fecha1 = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la segunda fecha (dd/mm/aaaa):");
fecha2 = DateTime.Parse(Console.ReadLine());

diferencia = fecha2 - fecha1;

Console.WriteLine("La diferencia entre ambas fechas es de {0} días.", Math.Abs(diferencia.Days));
Console.ReadKey();

