int PullThird(int number)
{
    if (number / 100 < 1)
    {
        int result = -1;
        return result;
    }
     else
     {
        int result = number % 10;
        return result;
     }
 }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdNumber = PullThird(number);
if (ThirdNumber == -1)
{
    Console.WriteLine("Третей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра {ThirdNumber}");
}