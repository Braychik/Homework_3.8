/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

using System;
using static System.Console;


Clear();
Write("Введите число строк: ");
int rows = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());
Write("Введите колтчество страниц: ");
int dep = int.Parse(ReadLine());

int[,,] array = GetArray(rows, columns, dep, 0, 100);
PrintArray(array);
WriteLine();

int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int s = 0; s < k; s++)
            {
                result[i, j, s] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int s = 0; s < inArray.GetLength(2); s++)
            {
                Write($"{inArray[i,j,s]} ({i} {j} {s}) ");
            }
            WriteLine();
        }
    }
} 
