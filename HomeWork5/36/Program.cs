Console.WriteLine("Введите длину массива");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (!isNumber || length<=0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

int[] FillArray(int Length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length-1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write(array[array.Length-1]);
Console.WriteLine("]");
}

int SumNumberInOddPositionInArray(int[] array)
{
    int countNumber = 0;
    for (int i = 1; i < array.Length; i=i + 2)
    {
        countNumber = countNumber + array[i];
    }
    return countNumber;
}

int [] array = FillArray(length);
PrintArray(array);
int result = SumNumberInOddPositionInArray(array);
Console.WriteLine($"Сумма элементов на нечетных позициях равна {result}");
