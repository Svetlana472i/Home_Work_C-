int PullSecondNumber(int PullSecondNumber) 
{
int result = (number / 10) % 10;
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number / 10) % 10;
Console.WriteLine(result);