﻿/*
    Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Write("Введите два числа: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
int num2 = int.Parse(Console.ReadLine() ?? "");

if (num1 > num2)
{
    Console.WriteLine($"Наибольшее число - '{num1}'");
}
else
{
    Console.WriteLine($"Наибольшее число - '{num2}'");
}