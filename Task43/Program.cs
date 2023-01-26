// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте значение b1:");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение k1:");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение b2:");
double numberB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение k2:");
double numberK2 = Convert.ToDouble(Console.ReadLine());

double numberX = GetX(numberB1, numberK1, numberB2, numberK2);
double numberY = GetY(numberX, numberB2, numberK2);
PointPrint(numberK2, numberK1, numberX, numberY);


double GetX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double GetY(double b2, double k2, double x)
{
    double y = numberK2 * numberX + numberB2;
    return y;
}

void PointPrint(double k2, double k1, double x, double y)
{
    if (numberK2 == numberK1) Console.Write("Прямые параллельны и не пересекаются");
    else Console.Write($"Точка пересечения прямых: ({Math.Round(numberX, 2)}; {Math.Round(numberY, 2)})");
}




