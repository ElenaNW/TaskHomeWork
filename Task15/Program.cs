// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 1 -> нет

Console.WriteLine("Введите однозначное число от 1 до 7:");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay >= 1 && numberDay <= 5)
{
    Console.Write("Нет");
}
else if (numberDay >= 6 && numberDay <= 7)
{
    Console.Write("Да");
}
else
{
    Console.Write("Вы ввели некорректное значение");
}