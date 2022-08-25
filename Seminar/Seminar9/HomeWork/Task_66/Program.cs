﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetSumNumbers(int m, int n)
{
    int sum = m;
    if (m >= n) return sum;
    return sum += GetSumNumbers(++m, n);
}

int sum = GetSumNumbers(m, n);
Console.WriteLine($"Сумма чисел в заданном интервале -> {sum}");