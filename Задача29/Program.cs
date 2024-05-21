// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
Console.Clear();

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = i + 1; //
}

Console.WriteLine("Элементы массива:");
foreach (int element in array)
{
    Console.Write(element + " ");
}