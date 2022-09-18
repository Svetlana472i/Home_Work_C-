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

int[,] OrderRows(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
         
    } 
    return array;
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
Console.WriteLine();
int[,] orderRows = OrderRows(result);
Print2DArray(orderRows);
