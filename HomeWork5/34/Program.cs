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
        array[i] = random.Next(0, 1000);
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

int SearchEvenNumberInArray(int[] array)
{
    int countNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countNumber = countNumber + 1;
        }
    }
    return countNumber;
}

int [] array = FillArray(length);
PrintArray(array);
int result = SearchEvenNumberInArray(array);
Console.WriteLine($"В данном массиве {result} четных чисел");
