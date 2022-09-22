Console.WriteLine("Введите число m - начало массива");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число n - конец массива");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);


if (!isNumberm || m <= 0 || !isNumbern || n <= 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}


int RecursivSumFromMTON(int m, int n, int i = 0)
{
    if (m == n)
    {
        return m;
    }
    return m + RecursivSumFromMTON(m+1, n, i+1);
}


int result = RecursivSumFromMTON(m, n);
Console.WriteLine(result);
