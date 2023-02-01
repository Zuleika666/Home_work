/* Напишите программу, которая принимает  на вход число (А) и выдает суммц чисел от 1 до А*/

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSumOfRange(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i;
    }
    return sum;
}

int end = GetUserData("Введите число А ");
int sum = getSumOfRange(1, end);
Console.WriteLine($"Сумма числел от 1 до А({end}) = {sum}");
