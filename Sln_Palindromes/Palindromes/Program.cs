// See https://aka.ms/new-console-template for more information

/*
 You will be given a string and you task is to check if it is possible to convert that string into a palindrome by removing a single character. 
 If the string is already a palindrome, return "OK". If it is not, and we can convert it to a palindrome by removing one character, then return "remove one", 
 otherwise return "not possible". The order of the characters should not be changed.
 */


using Palindromes;

Console.WriteLine("Enter a word to check if it is a palindrome");
string str = Console.ReadLine() ?? "";

if (Methods.IsPalindrome(str)) Console.WriteLine("If it is a palindrome.");
else if (Methods.SingleCharacterPalindromes(str)) Console.WriteLine("It's a palindrome without one letter.");
else Console.WriteLine("It is not a palindrome.");