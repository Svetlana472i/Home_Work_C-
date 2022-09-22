Console.WriteLine("Введите число m - начало массива");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число n - конец массива");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);


if (!isNumberm || m <= 0 || !isNumbern || n <= 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[] array = new int[n-m+1];
int[] RecursivFromMTON(int m, int n, int[] array, int i = 0)
{
    if (m == n +1)
    {
        return array;
    }
    array[i] = m;
    RecursivFromMTON(++m, n, array, ++i);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int[] result = RecursivFromMTON(m, n, array);
PrintArray(result);
