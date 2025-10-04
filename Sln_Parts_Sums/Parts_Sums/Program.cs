// See https://aka.ms/new-console-template for more information

/*
 The function parts_sums (or its variants in other languages) will take as parameter a list ls and return a list of the sums of its parts
 */

using Parts_Sums;

int[] arr = [1, 2, 3, 4, 5];
int[] Arr = Methods.PartsSums(arr);
string printArr = string.Join(", ", Arr);
Console.WriteLine($"[{printArr}]");
