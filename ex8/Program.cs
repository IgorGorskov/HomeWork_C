Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n - 1; i++)
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
if ((n - 1) % 2 == 0)
    Console.Write(n - 1);
else
    Console.Write(n);