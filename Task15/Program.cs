// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// string[] weekday = { " ", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// Console.Write("Введите  число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number <= 0 || number >= 8)
// {
//     Console.Write("Неверное число! ");
//     Environment.Exit(0);
// }
// if (number <= 5)
// {
//     Console.Write($"{weekday[number]} - не является выходным днём " );
// }
// else
// {
//     Console.Write($"{weekday[number]} - является выходным днём " );
// }

// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("Это понедельник, не является выходным днём");
}
else if (a == 2)
{
    Console.WriteLine("Это вторник, не является выходным днём");

}
else if (a == 3)
{
    Console.WriteLine("Это среда, не является выходным днём");
}
else if (a == 4)
{
    Console.WriteLine("Это четверг, не является выходным днём");
}
else if (a == 5)
{
    Console.WriteLine("Это пятница, не является выходным днём");
}
else if (a == 6)
{
    Console.WriteLine("Это суббота, является выходным днём");
}
else if (a == 7)
{
    Console.WriteLine("Это воскресенье, является выходным днём");
}
else Console.WriteLine("Введенно некорректное значение");




