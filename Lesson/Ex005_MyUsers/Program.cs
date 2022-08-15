Console.Write("Введите Ваше имя: ");
string? username = Console.ReadLine();
if (username == null) username = "";

if (username.ToLower() == "евгений")
{
    Console.Write("Приветствую, мой гениальный господин и создатель, Евгений!");
}
else if (username.ToLower() == "маша")
{
    Console.Write("Приветствую тебя, Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!");
}