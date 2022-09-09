Console.WriteLine("Сколько чисел вы хотите ввести?");
bool isNumber = int.TryParse(Console.ReadLine(), out int m);
if (isNumber == false || m<=0)
{
    Console.WriteLine("Число введено неверно");
    return;
}

double[] inputArray = new double[m];
int count = 0;

double[] FillArray(int m)
{
     int length = m;
    for (int i = 0; i < length; i++)
    {
      Console.WriteLine($"Введите {i+1}-е число");
      inputArray[i] = Convert.ToDouble(Console.ReadLine());    
      if (inputArray[i] > 0)
      {
        count++;
      }
}
    return inputArray; 
}

void PrintArray(double[] arr)
{   int n = arr.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}
double[] array = FillArray(m);
Console.Write("Вы ввели следующие числа: ");
PrintArray(array);
Console.WriteLine($"Среди них {count} больше 0");
