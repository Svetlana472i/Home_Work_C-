Console.WriteLine("Введите количество строк");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberm || m <= 0 || !isNumbern || n <= 0)
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

double[] GetArithmeticMeanСоlumn(int [,] array)
{
    double[] arr = new double[n];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
         for (int i = 0; i < array.GetLength(0); i++)
         
            arr[j] = arr[j] + array[i, j];
    } 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i] / array.GetLength(0), 2);
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}, ");
}

int[,] result = FillArray(m,n);
Console.WriteLine("Задан масив");
Print2DArray(result);
Console.Write("Среднее арирфметическое столбцов: ");
double[] ArithmeticMeanСоlumn = GetArithmeticMeanСоlumn(result);
PrintArray(ArithmeticMeanСоlumn);
