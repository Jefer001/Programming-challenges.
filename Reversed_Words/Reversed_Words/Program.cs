// See https://aka.ms/new-console-template for more information

/*
 Complete the solution so that it reverses all of the words within the string passed in.
 Words are separated by exactly one space and there are no leading or trailing spaces.

 Completa la solución para que invierta todas las palabras dentro de la cadena pasada.
 Las palabras están separadas por un solo espacio y no hay espacios al principio ni al final.
 */
using Reversed_Words;

Console.WriteLine("Enter the words you want to reverse.");
string str = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"{str} Is.EqualTo { Methods.ReverseWords(str)}");
