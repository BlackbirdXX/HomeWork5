// Задача 38:
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();

Write("Программа, которая показывает разницу между максимальным и минимальным элементов массива.\n");

WriteLine("Введите размер массива:");
int size = Convert.ToInt32(ReadLine());
WriteLine("Введите минимальное значение элемента массива:");
int minVal = Convert.ToInt32(ReadLine());
WriteLine("Введите максимальное значение элемента массива:");
int maxVal = Convert.ToInt32(ReadLine());
int[] array = CreateRandomArray(size, minVal, maxVal);

WriteLine($"\n[{String.Join(",", array)}]");

WriteLine($"Разность максимального и минимального чисел в массиве равна {GetDifference(array)}.");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

int GetDifference(int[] arr)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];

    }
    return max - min;
}
