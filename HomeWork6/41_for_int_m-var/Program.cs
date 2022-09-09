int w = 1000000;
double[] a = new double[0];
double [] inputArray = new double[w];
int count = 0;
int i = 0;

double[] FillArray(int m)
{
    for (i = 0; i < m; i++)
    {
      Console.WriteLine($"Введите {i+1}-е число");
      bool isNumberArray = double.TryParse(Console.ReadLine(), out inputArray[i]);
      if (!isNumberArray)
      {
        Console.WriteLine("Число введено неверно");
        return a;
      }
      
      if (inputArray[i] > 0)
      {
        count++;
      }
    }
    return inputArray;
}
double[] array = FillArray(w);
Console.WriteLine($"Вы ввели {i} чисел, среди них {count} больше 0");
