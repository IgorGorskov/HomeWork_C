Console.WriteLine("Введите 3 числа");

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max;

if (a > b)
    max = a;
else
    max = b;
if (max > c)
    Console.WriteLine($"max = {max}");
else
    Console.WriteLine($"max = {c}");