// программа, которая находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите значение точки b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
void Point (int b1, int b2, int k1, int k2)
{
double a = (b2 - b1);
double b = (k1 - k2);
double x = a / b;
double y =  k2 * x + b2;
Console.WriteLine(y);
if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые паралельны");
}
else
Console.WriteLine($"Точка пересечения ({x};{y})");
}
Point(b1,b2,k1,k2);