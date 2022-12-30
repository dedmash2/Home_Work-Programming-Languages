/*
    Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num == 0)
{
    Console.WriteLine("Ноль не четное число!!!");
}
else if (num % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}