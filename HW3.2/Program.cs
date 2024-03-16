// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве

int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next();
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

int CountEvenNumberArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
           count = count + 1;
        }
    }
    return count;
}

System.Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size);
PrintArray(arr);
System.Console.WriteLine();

int count = CountEvenNumberArray(arr);
System.Console.WriteLine(count);