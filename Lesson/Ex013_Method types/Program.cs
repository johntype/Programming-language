Console.Clear();
// Условная классификаци методов

// Группа 1
// Не принимают аргументыи ничего не возвращают

// void MethodOne()
// {
//     Console.WriteLine("Автор ФИО");
// }

//MethodOne();      // вызов метода

// Группа 2
// Принимают аргументы и ничего не возвращают

// void MethodTwo(string name, int date)
// {
//     Console.WriteLine($"Автор {name}, {date}");
// }

// Console.WriteLine("Введите свое имя: ");
// string authorName = Console.ReadLine();
// Console.WriteLine("Введите дату: ");
// int date = Convert.ToInt32(Console.ReadLine());

// MethodTwo(name: authorName, date: date);

// Группа 3
// Не принимают на вход данные в виде аргументов, но  возвращают результат

// int MethodThree()
// {
//     return DateTime.Now.Year;
// }

//int year = MethodThree();
//Console.WriteLine(year);


// Группа 4
// Принимают на вход данные в виде аргументов и возвращают результат

string MethodFourth(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

Console.WriteLine("Введите текст: ");
string? userText = Console.ReadLine();
if (userText == null) userText = "";
Console.WriteLine("Сколько раз необходимо повторить текст?: ");
int userCount = Convert.ToInt32(Console.ReadLine());
string res = MethodFourth(text: userText, count: userCount);
Console.WriteLine($"{res}");