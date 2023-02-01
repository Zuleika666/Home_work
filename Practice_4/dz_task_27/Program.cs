/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11 */ 

Console.Clear();



int GetUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}


int CountOfDigits(int num)
{
    
    int count = 0;
    while(num!=0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}

int SumOfDig(int count, int num)
{ 
    int res = 0;
    for (int i = 0; i <= count; i++)
    {
        res = res + (num % 10);
        
        num = num / 10;
    }
    return res;
}

int num = GetUserData("введите число");
int count = CountOfDigits(num);
int sum = SumOfDig(count, num);
Console.WriteLine(sum);
