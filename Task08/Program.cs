// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startN = 2;
while (startN <= number)
{
    Console.Write(startN + " ");
    startN = startN + 2;
}


