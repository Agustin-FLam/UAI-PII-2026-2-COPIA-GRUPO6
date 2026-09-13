/******************************************************************************

Calcular el factorial de 6.
*******************************************************************************/
int factorial = 6;

for (int i = 6 -1; i > 1; i--) {
    factorial = factorial * i;
}
Console.WriteLine("El facotorial de 6 es: {0}", factorial);