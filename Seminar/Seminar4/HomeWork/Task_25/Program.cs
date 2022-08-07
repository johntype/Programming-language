// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int ExponentiationNumber(int number1, int number2)
{
    int mult = 1;
    for (int i = 1; i <= num2; i++)
    {
        mult = mult * num1;
    }
    return mult;
}

int res = ExponentiationNumber(num1, num2);
Console.WriteLine($"{num1},{num2} -> {res}");