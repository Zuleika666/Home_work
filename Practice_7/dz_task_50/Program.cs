/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

string FindNum(int [,] array, int num)
{
    string res = "Такого числа нет";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == num)
            {
                res = $"позиция вашего числа в массиве [{i},{j}]";
                break;
            }
 
        }
    }
    return res;
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

int m = GetUserData("Введите количество столбцов");
int n = GetUserData("Введите количество строк");
int [,] array = GetArray(n, m, 0, 100);
PrintArray(array);
int num = GetUserData("Введите ваше число");
string result = FindNum(array, num);
Console.WriteLine(result);
