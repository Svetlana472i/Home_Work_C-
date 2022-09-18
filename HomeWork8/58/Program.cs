Console.WriteLine("Введите количество строк первой матрицы");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов первщй матрицы");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите количество столбцов второй матрицы");
bool isNumberk = int.TryParse(Console.ReadLine(), out int k);


if (!isNumberm || m <= 0 || !isNumbern || n <= 0 || !isNumberk || k <= 0)
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

int[,] MultiplicationArray(int [,] array1, int [,] array2)
{
    int[,] multpArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    { 
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                multpArray[i, j] = multpArray[i, j] + (array1[i, k] * array2[k, j]);
            }
        }
         
    } 
    return multpArray;
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


int[,] result1 = FillArray(m,n);
Console.WriteLine("Матрица № 1");
Print2DArray(result1);
int[,] result2 = FillArray(n,k);
Console.WriteLine("Матрица № 2");
Print2DArray(result2);
Console.WriteLine("Результат перемножения матрицы № 1 на матрицу № 2");
int[,] result = MultiplicationArray(result1, result2);
Print2DArray(result);

