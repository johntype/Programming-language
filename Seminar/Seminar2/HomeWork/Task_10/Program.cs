// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = removeFirstThird(num);

Console.WriteLine($"{num} -> {res}");

int removeFirstThird(int num)
{
    int first = num / 100;
    int two = num / 10 % 10;
    int third = num % 10;
    return two;
}

