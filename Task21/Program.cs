// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(Lenght(xA, yA, zA, xB, yB, zB), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {result}");

double Lenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}