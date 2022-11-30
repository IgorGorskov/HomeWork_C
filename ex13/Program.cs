Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int i = 1;


if (n < 100)
    Console.WriteLine("третьей цифры не");
else
    while (m > 10)       // цикл для нахождения количества цифр
    {
        m = m / 10; 
        i++;
    }

i = i - 3; 
while (i != 0)            // цикл для отбрасывания всех чисел до
    {                     // нужного разряда
        n = n / 10;
        i--;
    }
n = n % 10;

Console.WriteLine(n);