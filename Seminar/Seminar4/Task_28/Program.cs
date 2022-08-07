// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetDigitCount(int num)
{
    int count = 1;
    for (int i = 1; i <= num; i++)
    {
        count = count * i;
    }

    return count;
}
int res = GetDigitCount(num);
Console.WriteLine($"{num} -> {res}");