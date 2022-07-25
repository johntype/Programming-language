// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите целое число: ");
int day_week = Convert.ToInt32(Console.ReadLine());

if (day_week > 7 || day_week < 1)
{
    Console.WriteLine("Ошибка");
}
else if (day_week == 6 || day_week == 7)
{
    Console.WriteLine($"{day_week} -> Да");
}
else
{
    Console.WriteLine($"{day_week} -> Нет");
}
