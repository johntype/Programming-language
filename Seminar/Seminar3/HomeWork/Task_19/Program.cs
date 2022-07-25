// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int OldNum = num;
int NewNum = 0;
int k = 0;

while (num > 0)
{
    k = num % 10;
    NewNum = NewNum * 10 + k;
    num = num / 10;
    i++;
}

if (NewNum == OldNum) Console.WriteLine($"{NewNum} -> Да");
else Console.WriteLine($"{OldNum} -> Нет");
