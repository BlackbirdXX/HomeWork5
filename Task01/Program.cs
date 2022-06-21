// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using System;
using static System.Console;
Clear();

Write("Программа, которая показывает колличество четных чисел в массиве");

int[] array = CreateRandomArray(10, 100, 1000);

WriteLine($"\n[{String.Join(",", array)}]");
WriteLine($"Коллисество четных чисел в массиве равно {GetEvenNumberCount(array)}.");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }
    return newArray;
}

int GetEvenNumberCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        { count++; }

    }
    return count;
}