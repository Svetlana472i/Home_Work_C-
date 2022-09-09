Console.WriteLine("Ведите k1");
bool isNumberk1 = Double.TryParse(Console.ReadLine(), out double k1);
Console.WriteLine("Ведите b1");
bool isNumberb1 = Double.TryParse(Console.ReadLine(), out double b1);
Console.WriteLine("Ведите k2");
bool isNumberk2 = Double.TryParse(Console.ReadLine(), out double k2);
Console.WriteLine("Ведите b2");
bool isNumberb2 = Double.TryParse(Console.ReadLine(), out double b2);
                
if (!isNumberk1 || !isNumberb1 || !isNumberk2 || !isNumberb2)
{
    Console.WriteLine("Введенные символы не являются рациональными числами");
    return;
}

if (k1 == k2)
{
    Console.WriteLine("Заданные прямые параллельны");
    return;
}

double[] cutLines= new double[2];
double[] GetCutLines(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    cutLines[0] = x;
    cutLines[1] = y;
    return cutLines;
}
void PrintArray(double[] arr)
{   int n = arr.Length;
    Console.Write("(");
    for (int i = 0; i < n-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine(arr[n-1] +")");
}

double[] result = GetCutLines(k1, b1, k2, b2);
Console.Write("Прямые пересекаются в точке с координатами: ");
PrintArray(cutLines);


