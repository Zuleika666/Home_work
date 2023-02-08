/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.   */

Console.Clear();

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double Get_x (double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double Get_y(double x, double k1, double b1)
{ 
    double y = k1 * x + b1;
    return y;
}
 
double k1 = GetUserData("Введите k1:");
double b1 = GetUserData("Введите b1:");
double k2 = GetUserData("Введите k2:");
double b2 = GetUserData("Введите b2:");
double x = Get_x(k1, b1, k2, b2);
double y = Get_y(x, k1, b1);
Console.WriteLine(x);
Console.WriteLine($"Точкой пересечения прямых у = {k1} * x + {b1} и y = {k2} * x + {b2} является ({x} ; {y})");
