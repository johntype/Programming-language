// f(1) = 1; 
// f(2) = 1;
// f(n) = fn-1 + fn-2

int GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double GetFibonacci(int number)
{
    if (number == 1 || number == 2) return 1;
    else return GetFibonacci(number - 1) + GetFibonacci(number - 2);
}

void PrintFibonacciSequence(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"Число Фибоначчи под номером {i} --> {GetFibonacci(i)}");
    }
}

Console.Clear();
int numFi = GetUserInputInt("Введите количество чисел Фибоначчи: ");
PrintFibonacciSequence(numFi);