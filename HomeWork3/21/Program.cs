Console.WriteLine("Введите координату x точки A");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки A");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки A");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки B");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки B");
int Bz = Convert.ToInt32(Console.ReadLine());
double GetLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double temp = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2-z1), 2));
    return temp;
}
double length = GetLength(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine($"Расстояние между точками равно {length}");