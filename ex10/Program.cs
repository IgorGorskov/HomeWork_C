Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int m = (n / 10) % 10;
Console.WriteLine(m);