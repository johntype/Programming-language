// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.Clear();
Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i] + "]");
    }
}


void GetNum(int[] array, int number)
{
    int Res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            Res++;
    }
    if (Res == 0) Console.WriteLine($"Числа {num} нет в массиве");
    else Console.WriteLine($"Число {num} есть в массиве");
}

int[] array = CreateArrayRnd(5, 0, 10);
PrintArray(array);
Console.WriteLine();
GetNum(array, num);