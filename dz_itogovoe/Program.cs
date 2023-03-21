/* Написать программу, которая из имеющегося массива строк фомирует массив из строк,
длинна которых меньше либо равна 3 символа
*/
Console.Clear();

string GetUserData(string message)
{
    Console.WriteLine(message);
    string userData = Console.ReadLine();
    return userData;
}

string [] GetArray(int number)
{
    string [] array = new string[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = GetUserData($"Введите {i+1}й элемент массива");
        
    }
    return array;
}

int GetLenNewArr(string [] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<4)
        counter++;
    }
    return counter;
}

string [] GetNewArray(int len, string [] array)
{
    string [] new_arr = new string[len];
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<4)
        {
            new_arr[counter] = array[i];
            counter++;
        }
    }
    return new_arr;
}

void showArray(string[] arr)
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

string num = GetUserData("Введите длину массива");
int numm = Convert.ToInt32(num);
string [] arr1 = GetArray(numm);
int len_new_arr = GetLenNewArr(arr1);
string [] arr2 = GetNewArray(len_new_arr, arr1);

showArray(arr1);
Console.WriteLine();
showArray(arr2);