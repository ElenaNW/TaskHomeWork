// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
int[] arraySumRow = ArraySumRow(array2D);
PrintArray(arraySumRow);
int minRowIndex = FindMinSum(arraySumRow);
Console.WriteLine($"Наименьшая сумма элементов находится в строке {minRowIndex}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

int[] ArraySumRow(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            arr[i] = sum;
        }
    }
    return arr; 
}

void PrintArray(int[] arr)
{
    int numberOfRow = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.WriteLine
        (arr[i] + $" -> сумма элементов {numberOfRow}й строки,");
        else Console.WriteLine(arr[i] + $" -> сумма элементов {numberOfRow}й строки");
        numberOfRow++;
    }
}

int FindMinSum(int[]arr)
{
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[minIndex] >= arr[i]) minIndex = i;
    }
    return minIndex+1;
}