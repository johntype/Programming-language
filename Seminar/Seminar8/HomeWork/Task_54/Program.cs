// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],2} ,");
            else Console.Write($"{array[i, j],2}]");
        }
        Console.WriteLine();
    }
}

void SelectionSort(int[,] array)
{
    int minPosition = array[0, 0];
    int temp = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        minPosition = 0;
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            minPosition = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[row, j] < array[row, minPosition]) minPosition = j;
            }
            temp = array[row, i];
            array[row, i] = array[row, minPosition];
            array[row, minPosition] = temp;
        }
    }
}

int[,] matrix = GetMatrix(5, 5);
PrintMatrix(matrix);
SelectionSort(matrix);
Console.WriteLine();
PrintMatrix(matrix);