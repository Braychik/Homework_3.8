/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using System;
using static System.Console;


Clear();
Write("Введите число строк: ");
int rows = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
int[,] array1 = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
PrintArray(array1);
WriteLine("-------------------------------");
PrintArray(MultiplyArray(array, array1));

int [,] MultiplyArray(int[,] array, int[,] array1)
{
    int[,] array2 = new int[array.GetLength(0), array1.GetLength(1)];
    if(array.GetLength(0) == array1.GetLength(1))
    {
        for(int i = 0; i < array2.GetLength(0); i++)
        {
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array2[i, j] += array[i, k] * array1[k, j];
                }
            }
        }
    }
    return array2;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
} 

