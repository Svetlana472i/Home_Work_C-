Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int rezult = number % 2;
if (rezult==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}