// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Задайте номер строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте номер столбца: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int findElement = FindElement(array2D, rowNumber, columnsNumber);
Console.WriteLine(findElement);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

 int FindElement(int[,] matrix, int rowNum, int columnsNum)
{
    int i = rowNum-1;
    int j = columnsNum-1;
    if (rowNum < 0 || rowNum > matrix.GetLength(0) ||
    columnsNum < 0 || columnsNum > matrix.GetLength(1))
    {
        Console.WriteLine($"{rowNumber}, {columnsNumber} -> Такого элемента в массиве нет");
    }
    return matrix[i, j];
}



