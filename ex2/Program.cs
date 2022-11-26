Console.WriteLine("Введите 2 числа:");
Console.Write("a = ");

int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine($"max = {a}");
else
    Console.WriteLine($"max = {b}");