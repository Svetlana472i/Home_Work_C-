Console.WriteLine("Введите целое положительное число N");
bool isNumber = int.TryParse(Console.ReadLine(), out int N);

if (!isNumber || N < 0)
{
    Console.WriteLine("Символы, введенные вами не являются целым положительным числом");
    return;
}
 
int[] TableCubeNumber(int n)
 { 
    int i = 1;
    int [] result = new int [n];
    for (i = 1; i <=n; i++)
     {
       result[i-1] = (int) Math.Pow(i, 3); 
     } 
    return result;
 } 

void PrintTableCubeNumber(int[] cube)
{
    int j = 0;
    int length = cube.Length;
    for (j = 0; j < length; j++)
     {
        Console.WriteLine(cube[j]);
     }
}
int [] tabResult = TableCubeNumber(N);
PrintTableCubeNumber(tabResult);