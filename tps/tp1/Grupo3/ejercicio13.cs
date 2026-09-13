//Ejercicio 13
//Dada una fecha mostrarla en el formato AAAAMMDD.

DateTime fecha;

Console.WriteLine("Ingrese una fecha (dd/mm/aaaa):");
fecha = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Fecha en formato AAAAMMDD: " + fecha.ToString("yyyyMMdd"));
