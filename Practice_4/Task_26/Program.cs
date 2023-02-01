/* Программа принимает н а вход число и сообщает сколько там уифр */ 

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int GetNumberOfDigit(int number)
{
    int number_of_digit = 0;
    while(number > 0)
    {
        number = number / 10;
        number_of_digit++;
    }
    return number_of_digit;
}

int number = GetUserData("Введите число");
int count = GetNumberOfDigit(number);
Console.WriteLine($"В числе {number} - {count} цифр ");