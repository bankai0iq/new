﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine($"{num1} кратно {num2}");
// }
// else
// {
//     Console.WriteLine($"{num1} не кратно {num2} , остаток {num1 % num2}");
// }

 int remains = Remains( num1,num2);
Console.WriteLine($"кратно ");

int Remains(int number1,int number2 )
{
    return number1 % number2;
}


