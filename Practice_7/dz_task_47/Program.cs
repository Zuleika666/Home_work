/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

double [,] GetDoubleArray(int col, int row, int start, int end)
{
    double[,] array = new double[col, row];
    int divider = 100;
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            array[i, j] = new Random().Next(start * divider, (end + 1) * divider) / (divider + 0.0);
        }
    }
    return array;
}

void Print2DArray(double [,] array)
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

int n = GetUserData("Введите количество столбцов");
int m = GetUserData("Введите количество строк");
double [,] array = GetDoubleArray(n, m, 0, 100);
Print2DArray(array);