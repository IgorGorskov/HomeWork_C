Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int ch1 = n / 10000;
int ch2 = (n - ch1 * 10000) / 1000;
if (n % 100 == ch1 + ch2 * 10)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");