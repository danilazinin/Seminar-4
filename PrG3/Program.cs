string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

Console.WriteLine(text);

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

 newText = Replace(text, 'к', 'К');
 Console.WriteLine(newText);
 
 Console.WriteLine();

 newText = Replace(text, 'С', 'с');
 Console.WriteLine(newText);


