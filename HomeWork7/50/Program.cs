Console.WriteLine("Введите количество строк");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите искомое целое число");
bool isNumbera = int.TryParse(Console.ReadLine(), out int a);


if (!isNumberm || m <= 0 || !isNumbern || n <= 0 || !isNumbera)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,10);
        }
    }
    return array;
}

int[] SearchIndex(int [,] array, int a)
{
    int[] arr = new int[2];
    arr[0] = -1;
    arr[1] = -1;
    for (int i = 0; i < array.GetLength(0); i++)
        {
         for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == a)
                { 
                    arr[0] = i;
                    arr[1] = j;
                    return arr;   
                }
         } 
    return arr;     
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}");
}

int[,] result = FillArray(m,n);
Console.WriteLine("Задан масив");
Print2DArray(result);
int[] foundIndex = SearchIndex(result, a);
if (foundIndex[1] == -1)
{
    Console.WriteLine($"Число {a} в данном массиве не найдено");
}
else
{
    //Console.WriteLine($"Число {a} находится на пересечении {foundIndex[0]} строки и {foundIndex[1]} столбца");
    Console.Write($"Индексы числа {a} : ");
    PrintArray(foundIndex);
}

