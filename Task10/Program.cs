// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
    Console.WriteLine($"Вторая цифра в числе {number}: {number / 10 % 10}");
else
    Console.WriteLine("Вы ввели не трёхзначное число");