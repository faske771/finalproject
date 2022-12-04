System.Console.WriteLine("Enter your text");
string text = new string(Console.ReadLine());
string[] textmassive(string text)
{
    string[] splited = text.Split(' ');
    text.Split(',');
    text.Split('.');
    text.Split('!');
    text.Split('?');
    text.Split('(');
    text.Split(')');
    text.Split(':');
    return splited;
}
int size(string[] splited)
{
    int resultlenght = 0;
    for (int i = 0; i < splited.Length; i++)
    {
        if (splited[i].Length < 4)
        {
            resultlenght = resultlenght + 1;
        }
    }
    return resultlenght;
}
string[] newarray(string[] splited, int resultlenght)
{
    string[] res = new string[resultlenght];
    int j = 0;
    for (int i = 0; i < splited.Length; i++)
    {
        if (splited[i].Length < 4)
        {
            res[j] = splited[i];
            j++;
        }
    }
    return res;
}
void ArrayPrint(string[] res)
{
    for (int i = 0; i < res.GetLength(0); i++)
    {
        Console.Write($"{res[i]} ");
    }
}
ArrayPrint(newarray(textmassive(text), size(textmassive(text))));