/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int GetUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int [,] GetArray(int col, int row, int start, int end)
{
    int[,] array = new int[col, row];
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            array[i, j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

double [] Averege(int [,] array, int col, int row)
{
    double [] arr_avg = new double[col];
    double sum = 0;
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            sum = sum + array[j, i];
        }
        arr_avg[i] = sum / row;
    }
    return arr_avg;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void showArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i != arr.Length -1)
        {
            Console.Write($"{arr[i]}, "); 
        }
        else
        {
            Console.Write($"{arr[i]}]"); 
        }
          
    }
}

int col = GetUserData("Введите количество строк");
int row = GetUserData("Введите количество столбцов");
int [,] array = GetArray(col, row, 0, 100);
PrintArray(array);
double [] avg_ar = Averege(array, col, row);
showArray(avg_ar);
