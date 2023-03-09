/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

 using System;
using static System.Console;


Clear();
Write("Введите число строк: ");
int rows = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int [] minArray = ArithMeanColumns(array, columns, rows);
WriteLine(string.Join(", ", minArray));
int min = minArray[0];
//int index = 0;
for(int i = 1; i < rows; i++){
if(min > minArray[i])
{
    min = minArray[i];
}
} 
int index = 0;
for(int j = 0; j < rows; j++){
    if(minArray[j] == min)
    index = j;
}

    WriteLine($"Строка с наименьшей суммой -> № {index + 1} = {min}");


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
int[] ArithMeanColumns(int[,] inArray, int a, int b)
{
    int[] result = new int[b];
        for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           result[i] += array[i, j];      
        }
    }
     return result;
}  

