// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).



Console.WriteLine("Введите номер четверти");
Console.Write("Четверть: ");
int x = Convert.ToInt32(Console.ReadLine()); // string num = Console.ReadLine()

string Qarter(int xc)
{
    if (xc == 1) return "x > 0; y > 0";
    if (xc == 2) return "x < 0; y > 0";
    if (xc == 3) return "x < 0; y < 0";
    if (xc == 4) return "x > 0; y < 0";
    return "Введены некорректные данные";
}

string result = Qarter(x);
Console.WriteLine(result);