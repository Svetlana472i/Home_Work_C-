﻿Console.WriteLine("Введите длину массива");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (!isNumber || length<=0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

double[] FillArray(int Length)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.NextDouble() * (101+100) -100;
    }
    return array;
}

void PrintArray(double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length-1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write(array[array.Length-1]);
Console.WriteLine("]");
}

double GetMaxNumberInArray(double[] array)
{
    double maxNumber = array[1];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    return maxNumber;
}

double GetMinNumberInArray(double[] array)
{
    double minNumber = array[1];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    return minNumber;
}

double[] array = FillArray(length);
PrintArray(array);
double maxNumber = GetMaxNumberInArray(array);
double minNumber = GetMinNumberInArray(array);
double result = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {result}");
