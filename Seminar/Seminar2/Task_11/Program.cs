// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 999);
int res = removeSecond(num);

Console.WriteLine($"{num} -> {res}");

int removeSecond(int num)
{
    int first = num / 100;
    int third = num % 10;
    return first * 10 + third;
}



// int num = new Random().Next(100, 999);
// int firstnum = num / 100;            // 456 -> 4
// int secondnum = num % 10;            // 456 -> 6
// int res = firstnum * 10 + secondnum;
// Console.WriteLine($"{num} -> {res}");

