/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

int Sum_Digs_in_nech_ind(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum += arr[i];
    }
    return sum;
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
int summ = Sum_Digs_in_nech_ind(array);
Console.WriteLine($"Сумма нечетныхчисел массива равна {summ}");