/* Задача 43: Напишите программу, которая найдёт точку пересечения 
 * двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 * значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Вычисление точки пересечения двух прямых вида y= kx+b");

// Вводим данные для первой прямой
Console.Write("Введите k1: ");
double k1=double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

// Вводим данные для второй прямой
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
}
else
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают и имеют множество общих точек");
    }
    else
    {
        DotXYCoordinate(k1, k2, b1, b2);
    }
}
void DotXYCoordinate (double k1, double k2, double b1, double b2)
    {
        Console.WriteLine("Прямые имеют точку пересечения");
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"x = {x}, y = {y}");
    }