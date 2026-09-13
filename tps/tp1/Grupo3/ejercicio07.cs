/******************************************************************************

Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular
cuántos bits hay en cualquier combinación de x KBytes. Explique cómo llegó a esa conclusión.

1 kbytes = 1024 bytes 
1024 bytes = 8142 bits

*******************************************************************************/
int numero, resultado, kbytes;
Console.WriteLine("Ingrese la cantidad de kbits que tiene");
kbytes = int.Parse(Console.ReadLine());
resultado = (kbytes * 1024) * 8;
Console.WriteLine("El numero de bits es de {0}", resultado);