// Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 
// 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 
// 41(1,1,0) 55(1,1,1)


int min = 9;
int max = 99;

int[,,] matrix3 = Create3DArrayInt(4, 3, 3);
bool printResult = PrintResult(matrix3);
//Print3DArray(matrix3);

int[,,] Create3DArrayInt(int pages, int rows, int columns)
{
    int[,,] matrix3 = new int[pages, rows, columns];

    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3.GetLength(2); k++)
            {
                int x = min;
                if (min < max)
                    matrix3[i, j, k] = min + 1;
                min++;
            }

        }
    }
    return matrix3;
}

void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + $"({i},{j},{k})" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

bool PrintResult(int[,,] matrix3)
{
    if (max % matrix3.GetLength(2) == 0) return true;
    return false;
}

if (printResult)
{
    Print3DArray(matrix3);
}
else
{
    Console.Write($"Число {max} не кратно количеству столбцов матрицы");
}