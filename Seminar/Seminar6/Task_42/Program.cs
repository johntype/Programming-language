// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Первое решение:

// Console.Clear();
// int num = GetUserInput();
// System.Console.WriteLine(ConvertToBinary(num));
// 
// int GetUserInput()
// {
//     Console.Write("Введите число: ");
//     return Convert.ToInt32(Console.ReadLine());
// }
// 
// string ConvertToBinary(int num)
// {
//     string binary = string.Empty;
// 
//     while (num >= 1)
//     {
//         binary += num % 2;
//         num /= 2;
//     }
//     var item = binary.Reverse();
//     binary = "";
//     foreach (var i in item)
//     {
//         binary += i.ToString();
//     }
// 
//     return binary;
// }

// Второе решение:

// Console.Clear();
// 
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// 
// string Result(int num1)
// {
//     string res = "";
//     while (num1 > 0)
//     {
//         res += num1 % 2;
//         num1 /= 2;
//     }
//     return res;
// }
// 
// void PrintString(string result)
// {
//     for (int i = result.Length - 1; i >= 0; i--)
//     {
//         Console.Write(result[i]);
//     }
// }
// 
// string res = Result(num);
// PrintString(res);

// // Третье решение

void ToBin(int n)
{
if (n == 0) return;
ToBin(n / 2);           //Console.Write(n % 2); // разворот результата (рекурсия)
Console.Write(n % 2);      //ToBin(n / 2);  
}

ToBin(44);

