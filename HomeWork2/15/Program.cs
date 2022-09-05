bool PullWeekEnd(int number)
{
    if (number == 6 | number == 7)
    {
        return true;
    }
     else
     {
        return false;
     }
 }

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
bool WeekEnd = PullWeekEnd(number);
if (WeekEnd == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}