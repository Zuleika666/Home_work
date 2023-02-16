/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] Multiply(int [,] arr1, int [,] arr2)
{
    int[,] resultMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i,k] * arr2[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
    return resultMatrix;
}


Console.WriteLine("Матрица 1:");
int [,] array1 = GenerateArray(5, 5, 0, 20);

int [,] array2 = GenerateArray(5, 5, 0, 20);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
PrintArray(array2);
int [,] result = Multiply(array1, array2);
Console.WriteLine("Результат умножения матриц:");
PrintArray(result);