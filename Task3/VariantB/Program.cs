////Коробчук А.
//3
// б) *Выполнить предыдущее задание,
// оформив вычисления расстояния между точками в виде метода.

using System;

class Program
{
  static double Sqr(double x2, double x1, double y2, double y1)
  {
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

  }
 static void Main(string[] args)
  {
  Console.Write("Введите координату х первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine($"{Sqr(x2, x1, y2, y1):F2}");  }
}