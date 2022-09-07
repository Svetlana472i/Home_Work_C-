Console.WriteLine("Введите длину массива");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

if (isNumber == false || n<=0)
{
    Console.WriteLine("Длина введена неверно");
    return;
}
int[] array = new int[n];

void FillArray(int[] bin)
{
     int length = bin.Length;
    for (int i = 0; i < length; i++)
    {
      Console.WriteLine($"Введите {i+1}-й элемент массива");
      bin[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{   int n = arr.Length;
    Console.Write("[");
    for (int i = 0; i < n-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[n-1]}]");
}
FillArray(array);
PrintArray(array);
