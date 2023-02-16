/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

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

int [] GetSumm(int[,] array)
{
    int [] arr2 = new int [array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum = sum + array[i, j];
        }
        arr2[i] = sum;
    }
    return arr2;
}


int MinSum(int[] array)
{
   int mini = 0; 
   for (int i = 0; i < array.Length-1; i++) 
   {
       mini = i;
       for (int j = i + 1; i < array.Length; j++)
       {
           if(array[j] < array[mini]) mini = j; 
       }
   }   
   return mini;
}



void PrintArray1D(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); 
    }
}

int [,] array = GenerateArray(5, 5, -20, 20);
PrintArray(array);
int [] sumArray = GetSumm(array);
Console.WriteLine("Сумма в каждой строке равна:");
PrintArray1D(sumArray);
int min = MinSum(sumArray);
Console.WriteLine($"Строкой с наименьшей суммой является: {min} строка");

