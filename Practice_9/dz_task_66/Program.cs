/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int GetUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int userN = GetUserData("Ввдите число N:");
int userM = GetUserData("Ввдите число M:");
int sum = SumToM(userN, userM);
Console.WriteLine($"Сумма чисел от N до M равна {sum}");

int SumToM(int N, int M)
{

    if(N == M) return M;
    else return N + SumToM(N + 1, M);
}