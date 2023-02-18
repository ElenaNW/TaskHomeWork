// Напишите программу, которая на вход принимает два числа 
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


/* Pflfxf 66
int result = SumOfNaturalNumbers(numberM, numberN);
if (IsNaturalNumbers(numberM, numberN)) Console.Write(result);
else Console.WriteLine("Number's type error");

int SumOfNaturalNumbers(int num1, int num2)
{
    if (num1 < num2) return num1 + SumOfNaturalNumbers(num1 + 1, num2);

    if (num1 > num2) return num1 + SumOfNaturalNumbers(num1 - 1, num2);

    if (num1 == num2) return num1;

    return num1;
}

bool IsNaturalNumbers(int num1, int num2)
{
    return (num1 > 0 && num2 > 0);
}

// Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int nNumber = Convert.ToInt32(Console.ReadLine());


int result = AckermanFunction(mNumber, nNumber);
if (IsPositiveNumbers(mNumber, nNumber)) Console.WriteLine(result);
else Console.WriteLine("Error of numbers input");


int AckermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM > 0 && numN == 0) return AckermanFunction(numM - 1, 1);
    else if (numM > 0 && numN > 0) return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
    else return numN + 1;
}

bool IsPositiveNumbers(int num1, int num2)
{
    return (num1 >= 0 && num2 >= 0);
}


// Написать программу, которая 
//из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



string[] mainString = MainStringArray();
PrintArray(mainString);
Console.Write(" -> ");
int count = CountNewLength(mainString);
string[] mewString = NewStringArray(mainString, count);
PrintArray(mewString);


string[] MainStringArray()
{
    string[] arrayString = new string[] { "hello", "2", "world", ":-)" };
    return arrayString;
}

int CountNewLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count += 1;
    }
    return count;
}

string[] NewStringArray(string[] array, int length)
{
    string[] newStringArray = new string[length];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newStringArray[j] = array[i];
            j++;
        }
    }
    return newStringArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}


// Задача 64: Задайте значение N. 
// Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (NaturalNumbersChecking(number)) 
{
    Console.Write("( ");
    NaturalNumbers(number);
    Console.Write(" )");
}
else Console.WriteLine("Isn't natural number");


void NaturalNumbers(int num)
{
    if (num == 0) return;
    {
        if (num == 1) Console.Write($"{num} ");
        else Console.Write($"{num}, ");
        NaturalNumbers(num - 1);
    }

   
}

bool NaturalNumbersChecking(int num1)
{
    return num1 > 0;
}
*/