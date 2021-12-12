////Коробчук А.
//3
// а) Написать программу, которая подсчитывает расстояние
// между точками с координатами x1, y1 и x2,y2 по формуле
//  r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
// Вывести результат, используя спецификатор формата
//   .2f (с двумя знаками после запятой);
Console.Write("Введите координату х первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine($"{r:F2}");
