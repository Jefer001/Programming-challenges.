// See https://aka.ms/new-console-template for more information

/*
 Given the string representations of two integers, return the string representation of the sum of those integers.
 A string representation of an integer will contain no characters besides the ten numerals "0" to "9".

 I have removed the use of BigInteger and BigDecimal in java
 */

using Sum_Strings_as_Numbers;

Console.WriteLine("Enter the first number");
string? a = Console.ReadLine();
Console.WriteLine("Enter the second number");
string? b = Console.ReadLine();

Console.WriteLine(Methods.SumStringsNum(a, b));