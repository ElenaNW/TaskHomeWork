// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arrayFirst2D = CreateMatrixRndInt(4, 3, 0, 5);
PrintMatrix(arrayFirst2D);
Console.WriteLine();
int[,] arraySecond2D = CreateMatrixRndInt(2, 4, 0, 5);
PrintMatrix(arraySecond2D);
Console.WriteLine();
int[,] resultMatrix = MultiplyMatrix(arrayFirst2D, arraySecond2D);
bool printResult = PrintResult(arrayFirst2D, arraySecond2D, resultMatrix);

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
        Console.WriteLine(string.Empty);
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            resMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resMatrix;
}

bool PrintResult(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) return true;
    return false;
}

if (printResult)
{
    Console.Write($"Перемножить данные матрицы невозможно");
}
else
{
    PrintMatrix(resultMatrix);
}

