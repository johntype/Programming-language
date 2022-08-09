// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
// double d = 4.234532;
// double res = Math.Round(d, 1);

double[] array = CreateArray(5);
double difference = FindDiff(array);
PrintResult(array, difference);


double[] CreateArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.NextDouble() * 100;
    }
    return array;
}

double FindDiff(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }

    return max - min;
}

void PrintResult(double[] array, double difference)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}");
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine($"] -> {Math.Round(difference, 2)}");
}