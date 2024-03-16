// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int n, int min, int max)
{
    double[] array = new double[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

double FindMaxNumberArray(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMinNumberArray(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

System.Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

double[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine();

double difference = FindMaxNumberArray(arr) - FindMinNumberArray(arr);
System.Console.WriteLine("Difference between max and min: " + difference);
