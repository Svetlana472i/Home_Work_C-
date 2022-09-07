Console.WriteLine("Введите координату x точки A");
bool resultAx = double.TryParse(Console.ReadLine(), out double Ax);
Console.WriteLine("Введите координату y точки A");
bool resultAy = double.TryParse(Console.ReadLine(), out double Ay);
Console.WriteLine("Введите координату z точки A");
bool resultAz = double.TryParse(Console.ReadLine(), out double Az);
Console.WriteLine("Введите координату x точки B");
bool resultBx = double.TryParse(Console.ReadLine(), out double Bx);
Console.WriteLine("Введите координату y точки B");
bool resultBy = double.TryParse(Console.ReadLine(), out double By);
Console.WriteLine("Введите координату z точки B");
bool resultBz = double.TryParse(Console.ReadLine(), out double Bz);

double GetLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double temp = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2-z1), 2));
    return temp;
}

double length = GetLength(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine($"Расстояние между точками равно {length}");