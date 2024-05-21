// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int sum = 0;
int originalNumber = number;
while (number != 0)
{
    int digit = number % 10;
    sum += digit;
    number /= 10;
}
Console.WriteLine($"Сумма цифр числа {originalNumber} равна {sum}");