Console.WriteLine("Введите Число");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);
if (!isNumber || number < 0)
{
    Console.WriteLine("Символы, введенны неверно");
    return;
}
int GetSumNumber(int number)
{
    int i = 0;
    int result = 0;
    if (number == 0)
    {
        return 0;
    }
    else 
    while (number != 0)
    {
        i++;
        result = result + number % 10;
        number = number / 10;
    }
return result;
}

int sum = GetSumNumber(number);
Console.WriteLine(sum);
