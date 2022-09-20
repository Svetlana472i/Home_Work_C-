Console.WriteLine("Введите размер массива");
bool ilNumberm = int.TryParse(Console.ReadLine(), out int m);

if (!ilNumberm || m <= 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i,j]} ");
            }
            else
            {
                Console.Write($"{array[i,j]} "); 
            }
        }
        Console.WriteLine();
    }
} 

int[,] FillArray(int m)
{
    int[,] array = new int[m, m];
    int p = 1;
        for (int i = 0; i < (m + 1) / 2; i++)
            {
                for (int j = i; j < m - i; j++)
                    {
                        array[i, j] = p; p++;
                    }
                for (int l = 1 + i; l < m - i; l++)
                    {
                        array[l, m - 1 - i] = p; p++;
                    }
                for (int n = m - 2 - i; n >= i; n--)
                    {
                        array[m - 1 - i, n] = p; p++;
                    }
                for (int k = m - 2 - i; k >= 1 + i; k--)
                    {
                        array[k, i] = p; p++;
                    }
            }
        return array;
}


int[,] result = FillArray(m);
Print2DArray(result);
