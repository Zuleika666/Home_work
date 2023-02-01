/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/ 

Console.Clear();

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double Action(int num, int deg)
{
    double result = Math.Pow(num, deg);
    return result;
}

int number = GetUserData("Введите число ");
int degree = GetUserData("Введите степень ");
double result = Action(number, degree);
Console.WriteLine($"Результатом возведения числа {number} в степень {degree} является = {result}");