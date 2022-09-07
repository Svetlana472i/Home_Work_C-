Console.WriteLine("Введите Число A");
bool isNumberA = double.TryParse(Console.ReadLine(), out double a);
Console.WriteLine("Введите Число B");
bool isNumberB = int.TryParse(Console.ReadLine(), out int b);
if (!isNumberA || !isNumberB || b < 0)
{
    Console.WriteLine("Символы, введенны неверно");
    return;
}
double Degree(double a, int b)
{
    double result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.WriteLine(Degree(a, b));