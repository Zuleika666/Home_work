/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();

Console.WriteLine("Введите число М:");
int M = int.Parse(Console.ReadLine()!);

int Vvod(string message)
{
    Console.WriteLine(message);
    int user_data = int.Parse(Console.ReadLine()!);
    return user_data;
}

int Count_numbers(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        int num = Vvod($"Введите {i+1}-е число:");
        if(num > 0) count++;
    }
    return count;
}

int count_nums = Count_numbers(M);
Console.WriteLine();
Console.WriteLine($"Вы ввели {count_nums} чисел больше 0");