// See https://aka.ms/new-console-template for more information
using System;
using QuickSort;

//Console.WriteLine("Hello, World!");
//Console.ReadLine();



int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
QuickSortLogic.QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine($"Sorted Array");
foreach (int num in arr)
{
    Console.WriteLine(num);
}

Console.ReadLine();
