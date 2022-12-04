System.Console.WriteLine("Enter your text");
string text = new string(Console.ReadLine());
string[] textmassive(string text)
{
    string[] splited = text.Split(' ');
                       text.Split(',');
                       text.Split('.');
                       text.Split('!');
                       text.Split('?');
    return splited;
}
string lenght(string[] splited)
{
string res = string.Empty;
for (int i = 0; i < splited.Length; i++)
{
    if (splited[i].Length <4) 
    {
        res += $"{splited[i]}, ";
    }
}
return res;
}
Console.WriteLine(lenght(textmassive(text)));