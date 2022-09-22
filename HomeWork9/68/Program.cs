Console.WriteLine("Введите первый аргумент функции");
bool isNumbera = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите второй аргумент функции");
bool isNumberb = int.TryParse(Console.ReadLine(), out int b);


if (!isNumbera || a < 0 || !isNumberb || b < 0)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

double RecursivAccerman(double m, double n, int i = 0)
{
    if (m == 0)
    {
        return n +1;
    }
    if (n == 0)
    {
        return RecursivAccerman(m-1, 1);
    }
    else
    {
       return RecursivAccerman(m - 1, RecursivAccerman(m, n-1));
    } 
}   


double result = RecursivAccerman(a, b);
Console.WriteLine($"Функция Аккермана ({a}, {b}) равна {result}");
