// 0. Демонстрация решения
// Напишите программу, которая 
// 1.на вход принимает число 
// 2. и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int a = 4; // -2.147 млрд до 2.147 млрд
// int b = -3;
// int c = -7;

int res1 = num * num;
// int res2 = b * b;
// int res3 = c * c;

Console.WriteLine($"Квадрат числа: {num} = {res1}");
// Console.WriteLine(res2);
// Console.WriteLine(res3);
// $ - позволяет нам напечатать значения переменных