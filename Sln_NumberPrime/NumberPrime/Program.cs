// See https://aka.ms/new-console-template for more information

/*
 Define a function that takes an integer argument and returns a logical value true or false depending on if the integer is a prime.
 Per Wikipedia, a prime number ( or a prime ) is a natural number greater than 1 that has no positive divisors other than 1 and itself.

 Defina una función que tome un argumento entero y devuelva un valor lógico verdadero o falso dependiendo de si el entero es un número primo.
 Según Wikipedia, un número primo (o primo) es un número natural mayor que 1 que no tiene divisores positivos distintos de 1 y de sí mismo.
 */

Console.WriteLine("Enter a number to find out if it is prime.");
int number = int.Parse(Console.ReadLine()!);
bool isPrime = NumberPrime.Methods.IsPrime(number);
Console.WriteLine(isPrime ? $"{number} It is a prime number." : $"{number} It is not a prime number.");

