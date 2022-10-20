// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void XY (double a, double b, double c, double d)
{
    double x = (c - a) / (b - d);
    double y = b * x + a;

    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

Console.WriteLine("введите значение 1 для первой прямой");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение 2 для первой прямой");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение 1 для второй прямой");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение 2 для второй прямой");
double k2 = Convert.ToInt32(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else 
XY (b1,k1,b2,k2);

