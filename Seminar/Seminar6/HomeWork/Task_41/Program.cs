// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

string[] stringNumM = GetUserInputNum("Введите числа через запятую: ");
int[] numM = ConvertArray(stringNumM);
int countPosNum = GetCountNumbOverNull(numM);
PrintArray(numM);


string[] GetUserInputNum(string userInputNum)
{
    Console.WriteLine(userInputNum);
    string[] strArray = Console.ReadLine().Split(",");
    return strArray;
}

int[] ConvertArray(string[] stringArray)
{
    int[] array = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        array[i] = Convert.ToInt32(stringArray[i]);
    }
    return array;
}

int GetCountNumbOverNull(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} -> {countPosNum}");
    }
}
