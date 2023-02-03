/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

int [] GetArrayRandom(int length)
{
    int [] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int Chet_Count(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0 ) count++;
    }
    return count;
}

void showArray(int[] arr)
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

int [] array = GetArrayRandom(8);
showArray(array);
Console.WriteLine();
int countt = Chet_Count(array);
Console.WriteLine($"В данном массиве {countt} четных чисел");