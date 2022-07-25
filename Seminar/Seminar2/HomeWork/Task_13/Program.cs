// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int res = 0;

while (num > 1000)
{
    num = num / 10;
}

if (num < 100)
{
    Console.WriteLine($" {num} -> третьей цифры нет ");
}



if (num > 99 && num < 1000)
{
    res = num % 10;
    Console.WriteLine($"{num1} -> {res}");
}
