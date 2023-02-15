/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2  */

Console.Clear();

int[,] GenerateArray(int colLength, int rowLength, int start, int finish)
{
    int [,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish +1);
        }
    }
    return array;
}

void PrintInColor(string data, ConsoleColor color)
{
     Console.ForegroundColor = color;
     Console.Write(data);
     Console.ResetColor();
}

void printHeadOfArray(int length)
{
    Console.Write(" \t");
    for (int i = 0; i < length; i++)
    {
        PrintInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}


void PrintArray(int [,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i+"\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int [,] array = GenerateArray(5, 6, -10, 20);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);


