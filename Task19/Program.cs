// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да

Console.WriteLine("Введите пятизначное натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10000 && number <= 99999)
{
    int firstNumber = number / 10000;
    int secondNumber = number / 1000 % 10;
    int fourthNumber = number / 10 % 10;
    int fifthNumber = number % 10;
    Console.WriteLine(Сompare(firstNumber, secondNumber, fourthNumber, fifthNumber) 
                      ? "Да" : "Нет");
}
else Console.WriteLine($"Вы ввели некорректное значение");

bool Сompare(int num1, int num2, int num4, int num5)
{
    return num1 == num5 && num2 == num4;
}


