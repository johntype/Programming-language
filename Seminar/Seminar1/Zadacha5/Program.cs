// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


Console.Clear();
Console.Write("Write a number N: ");
int n = Convert.ToInt32(Console.ReadLine()); // int.Parse(Console.ReadLine())

int i = 0;

if (n < 0)
{
i = n;
n = n * -1;
}
else
{
i = -n;
}

while (i <= n)
{
Console.Write($" {i} ");
i++;
}