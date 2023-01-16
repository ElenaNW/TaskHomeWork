// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int countSum = CountSum(number);
    Console.Write($"{number} -> {countSum}");
}
else Console.Write("Вы ввели некорректное значение");

int CountSum(int num)
{
    int count = 0;
    int sum = 0;
    int digit = 0;
    while (num > 0)
    {
        digit = num % 10;
        sum = sum + digit;
        num = num / 10;
        count++;
    }
    return sum;
}
