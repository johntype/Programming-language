// Итерация №1
// Решение в группах задач:
// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Clear();
// Console.Write("Введите целое число: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число: ");
// int num_2 = Convert.ToInt32(Console.ReadLine());
// int result = num_2 * num_2;
//     if (result == num_1) 
//     {
//         Console.WriteLine("Да");
//     }
//     else 
//     {
//         Console.WriteLine("Нет");
//     }

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число: ");
int day_week = Convert.ToInt32(Console.ReadLine());
    if (day_week == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (day_week == 2)
    {
        Console.WriteLine("Вторник");
    }
     else if (day_week == 3)
    {
        Console.WriteLine("Среда");
    }
     else if (day_week == 4)
    {
        Console.WriteLine("Четверг");
    }
     else if (day_week == 5)
    {
        Console.WriteLine("Пятница");
    }
     else if (day_week == 6)
    {
        Console.WriteLine("Суббота");
    }
     else if (day_week == 7)
    {
        Console.WriteLine("Воскресенье");
    }
     else 
    {
        Console.WriteLine("Ошибка");
    }
   
