// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num;
int firstDigit;
int thirdDigit;
int result;
num = new Random().Next(100, 1000);
Console.Write(num);
firstDigit = num / 100; //4 
thirdDigit = num % 10; //6
result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"-> {result}");