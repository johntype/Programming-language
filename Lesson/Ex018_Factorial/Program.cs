int GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double GetFactorial(int number)
{
    if (number == 0) return 1;
    else if (number == 1) return 1;
    else return number * GetFactorial(number - 1);
}

void PrintTableFactorial(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"Факотриал числа {i} равен {GetFactorial(i)}");
    }
}

Console.Clear();
int numF = GetUserInputInt("Факториал какого числа необходимо найти? ");
//double fact = GetFactorial(numF);
PrintTableFactorial(numF);

