Console.WriteLine("Введите количество строк");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberm || m <= 0 || !isNumbern || n <= 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[,] array = new int[m, n];
int[,] FillArray(int m, int n)
{
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

int[] temp = new int[array.GetLength(0)];
int[] GetStringSum(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[i] = temp[i] + array[i, j];
        }
    } 
    return temp;
}

int GetMin(int[] array)
{
    int min = array[1];
    int current = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            current = i;
        }
    }
    return current;
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

int[,] result = FillArray(m,n);
Print2DArray(result);
int[] result1 = GetStringSum(result);
int stringMinSum = GetMin(result1);
Console.Write("Номер строки с наименьшей суммой элементов:");
Console.WriteLine(stringMinSum+1);