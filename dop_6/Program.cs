// площадь треугольника
Console.WriteLine("Введите x1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x3");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y3");
double y3 = Convert.ToInt32(Console.ReadLine());

double a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
double b = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
double c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
double p = (a + b + c) / 2;

Console.WriteLine($"S = {Math.Sqrt((p * (p - a) * (p - b) * (p - c)))}");