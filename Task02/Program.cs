﻿// Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    Console.Write($"max = {number1}");
else
    Console.Write($"max = {number2}");
