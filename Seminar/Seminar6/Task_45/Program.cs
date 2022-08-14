// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array = CreateArrayRndInt(8, 1, 9);

int[] newArray = CopyArray(array);

Console.WriteLine("Исходный массив: " + WriteArrayAsString(array));
Console.WriteLine("Скопированный массив: " + WriteArrayAsString(newArray));
array[0] = 4;
Console.WriteLine("Изменили первый элемент массива: " + WriteArrayAsString(array));
Console.WriteLine("Скопированный массив без изменений: " + WriteArrayAsString(newArray));

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

string WriteArrayAsString(int[] array)
{
    System.Text.StringBuilder sb = new System.Text.StringBuilder();
    sb.Append("[");
    for (int i = 0; i < array.Length; i++)
    {
        sb.Append(array[i]);
        if (i < array.Length - 1)
            sb.Append(", ");
    }
    sb.Append("]");

    return sb.ToString();
}

