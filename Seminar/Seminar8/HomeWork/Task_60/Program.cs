// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. 
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InitMatrix(int m, int n, int p)
{
    int[,,] matrix = new int[m, n, p];
    int[] buffer = new int[m * n * p];
    int count = 0;
    Random randomizer = new Random();
    for (int i = 0; i < buffer.Length; i++)
    {
        buffer[i] = randomizer.Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (buffer[i] == buffer[j])
                {
                    buffer[i] = randomizer.Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = buffer[count];
                count++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k});   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

Random rnd = new Random();
int x = rnd.Next(1, 5);
int y = rnd.Next(1, 5);
int z = rnd.Next(1, 5);
int[,,] matrix3D = InitMatrix(x, y, z);
Console.WriteLine($"В матрице {x} строки,{y} столбца,{z} слоя.");
Console.WriteLine();
PrintMatrix(matrix3D);