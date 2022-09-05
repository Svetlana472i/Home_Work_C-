int PullSecond(int number)
{
     int result = (number / 10) % 10;
     return result;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = PullSecond(number);
Console.WriteLine(secondNumber);