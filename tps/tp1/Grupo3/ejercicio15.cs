//Ejercicio 15
//Informar cuantos días faltan para el 25/12/2020.

DateTime fechaObjetivo = new DateTime(2020, 12, 25);
DateTime fechaActual = DateTime.Now;
TimeSpan diasFaltantes;

diasFaltantes = fechaObjetivo - fechaActual;

Console.WriteLine("Faltan {0} días para el 25/12/2020.", diasFaltantes.Days);
Console.ReadKey();
