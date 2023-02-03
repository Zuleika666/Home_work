/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();

int [] GetArrayRandom(int length)
{
    int [] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 500);
    }
    return arr;
}

int Diff(int [] arr)
{
    int diff = 0;
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        
        if(arr[i+1]<min)
        {
            min = arr[i +1];
        }
        if(arr[i+1]>max)
        {
            max = arr[i + 1];
        }
        diff = max - min;
    }
    return diff;
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


Console.WriteLine("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine()!);
int [] array = GetArrayRandom(len);
showArray(array);
Console.WriteLine();
int difference = Diff(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {difference}");
