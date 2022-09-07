Console.WriteLine("Введите пятизначное положительное число N");
string N = Console.ReadLine();

string ToPal(string n)
{
    string pal = string.Empty;
    int length = n.Length;
    int i = length;
    for (i = length-1; i >= 0; i--)
    {
       pal = pal + $"{n[i]}";
    }
    return pal;
}

string result = ToPal(N);

if (N == result)
    {
       Console.WriteLine("Да");
    }
else
    {
       Console.WriteLine("Нет");
    }