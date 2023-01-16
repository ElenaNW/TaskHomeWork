// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberDegree = NumberDegree(numberA, numberB);
Console.Write($"{numberA},{numberB} -> {numberDegree}");

if (numberB > 0)
{
    NumberDegree(numberA, numberB);
}
else Console.Write("Число B не является натуральным");


int NumberDegree(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result = result * numA; 
    }
    return result;
}
