// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

using System;
using static System.Console;
Clear();

Write("Программа, которая показывает сумму элементов, стоящих на нечётных позициях в массиве.");

int[] array = CreateRandomArray(10, 0, 10);

WriteLine($"\n[{String.Join(",", array)}]");
WriteLine(GetOddNumberSum(array));


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

int GetOddNumberSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}