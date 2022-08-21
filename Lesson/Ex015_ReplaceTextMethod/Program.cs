Console.Clear();

// Console.WriteLine("Введите текст: ");
// string? userText = Console.ReadLine();
// if (userText == null) userText = "";

// string s = qwerty;
// 012345
// s[3] // r

string someText = "To be, or not to be--that is the question:"
                + "Whether 'tis nobler in the mind to suffer"
                + "The slings and arrows of outrageous fortune"
                + "Or to take arms against a sea of troubles"
                + "And by opposing end them. To die, to sleep--"
                + "No more--and by a sleep to say we end"
                + "The heartache, and the thousand natural shocks"
                + "That flesh is heir to. 'Tis a consummation"
                + "Devoutly to be wished. To die, to sleep--"
                + "To sleep--perchance to dream: ay, there 's the rub,"
                + "For in that sleep of death what dreams may come"
                + "When we have shuffled off this mortal coil,"
                + "Must give us pause. There's the respect"
                + "That makes calamity of so long life.";

string ReplaceText(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = ReplaceText(someText, ' ', '|');
Console.WriteLine($"{someText} --> {newText}");