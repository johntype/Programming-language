// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// // что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1, 7 -> такого числа в массиве нет
// 


Console.Write("Введите число строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = FillMatrixRandomNumbers(m, n);
PrintMatrix(Matrix);

int[,] FillMatrixRandomNumbers(int rows, int columns, int LeftRange = 0, int RightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(LeftRange, RightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте позиции искомого элемента: ");
Console.Write("Введите число, соответствующее номеру строки в двумерном массиве: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, соответствующее номеру столбца в двумерном массиве:  ");
int column = Convert.ToInt32(Console.ReadLine());

SearchElementRowColumn(Matrix, row, column);

void SearchElementRowColumn(int[,] matrix, int Row, int Column)
{

    if (Row < matrix.GetLength(0) && Column < matrix.GetLength(1))
    {

        Console.Write($"Значение элемента с индексом [{Row}, {Column}] = {matrix[Row, Column]}");
    }
    else
    {
        Console.Write($"В массиве отсутствует элемент с индексом [{Row}, {Column}]");
    }
}