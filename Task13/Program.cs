﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет ");
    Environment.Exit(0);
}
while (num > 999)
{
    num = num / 10;
}
num = num % 10;
Console.WriteLine(num);
