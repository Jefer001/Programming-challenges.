// See https://aka.ms/new-console-template for more information

/*
  Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
 
  Completa la solución para que devuelva verdadero si el primer argumento (cadena) pasado termina con el segundo argumento (también una cadena).
 */

using String_Ends_With;

Console.WriteLine("Enter the first word");
string str = Console.ReadLine();    
Console.WriteLine("Enter the second word");
string str2 = Console.ReadLine();
bool result = Methods.Solution(str, str2);
Console.WriteLine(result);
