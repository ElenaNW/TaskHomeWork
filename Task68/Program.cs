// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int resultOfFunction = AccermanFunction(numberM, numberN);

if (numberM >= 0 && numberN >= 0) Console.Write(resultOfFunction);
else Console.Write("Ошибка ввода. Введите натуральное число");

int AccermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AccermanFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AccermanFunction(numM - 1, AccermanFunction(numM, numN - 1));
    return numN + 1;
}
