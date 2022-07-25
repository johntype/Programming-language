// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i<=n)
// {
//     Console.WriteLine($"|{i} | {i * i}");

//     i++;    
// }




Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

WriteSquareTable(n);

void WriteSquareTable(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"| {i,3} | {i * i,3} |");
        i++;
    }
}