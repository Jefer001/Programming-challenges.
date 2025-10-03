// See https://aka.ms/new-console-template for more information

/*
 Your task is to write a function that takes an unsorted list of comparable values and a number K, representing the number of targets (ammo) to return. 
 The function should return a list containing the K smallest values from the input list.
 For example, given the list [1, 5, -3, 2] and K = 2, the function should return one of these lists: [-3, 1], [1, -3]. for k = 0 return an empty list
 */

using Smallest_K_Elements;

int[] arr = { 3, 2, 1 };
int[] result = Methods.GetSmallestKElements(arr, 2);
string print = string.Join(", ", result);
Console.WriteLine($"[{print}]");

