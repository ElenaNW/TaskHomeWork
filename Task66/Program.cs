// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int summa = NaturalNumbersRange(numberM, numberN);

if (numberM > 0 && numberN > 0) Console.Write(summa);
else Console.Write("Ошибка ввода. Введите натуральное число");


int NaturalNumbersRange(int numM, int numN)
{
    if (numM == numN) return 0;
    if (numM < numN) return numM + NaturalNumbersRange(numM + 1, numN);
    if (numM > numN) return numM + NaturalNumbersRange(numM - 1, numN);
    return numM;
}





