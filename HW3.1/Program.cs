// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int СonditionalCountNumberArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 20 && array[i] <= 90)
        {
           count = count + 1;
        }
    }
    return count;
}

System.Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();


int[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine();

int count = СonditionalCountNumberArray(arr);
System.Console.WriteLine(count);