// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Clear();

int n = InputNumbers("Введите число: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int sum1 = 0;

int Sum(int n, int sum)
{
    if (n == 0) return sum1;
    sum1 += n % 10;
    return Sum(n / 10, sum1);
}

int c = Sum(n,sum1);
Console.WriteLine(c);