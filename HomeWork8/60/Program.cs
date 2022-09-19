Console.WriteLine("Введите первую размерность массива");
bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите вторую размерность массива");
bool isNumbern = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите третью размерность массива");
bool isNumberl = int.TryParse(Console.ReadLine(), out int l);

if (!isNumberm || m <= 0 || !isNumbern || n <= 0 || !isNumberl || l <= 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

 if (m * n * l > 90)
    {
        Console.WriteLine("Слишком большая размерность массива");
        return;
    }

bool Test(int[,,] array, int a)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == a)
                {
                   return true;
                }
            }
        }
    }
    return false;
}

int[,,] FillArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    int temp = 0;
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                temp = random.Next(10,100);
                while (Test(array, temp))
                {
                    temp = random.Next(10,100);
                }
                array[i,j,k] = temp;
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
} 


int[,,] result = FillArray(m,n,l);
Print3DArray(result);
