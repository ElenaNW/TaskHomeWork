// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(1, 24000);
Console.WriteLine($"Случайное число: {number}");
if (number >= 100)
{
    if (number >= 100 && number <= 999)
    {
        Console.WriteLine($"Третья цифра числа -> {RemainsNumber(number)}");
    }
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine($"Третья цифра числа -> {RemainsNumber(number)}");
    }
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}



int RemainsNumber(int num)
{
    return number % 10;
}