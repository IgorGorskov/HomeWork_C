Console.WriteLine("Введите число кустов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ягод на каждом кусте");

int cherry1 = Convert.ToInt32(Console.ReadLine());
int cherry2 = Convert.ToInt32(Console.ReadLine());
int cherry3 = Convert.ToInt32(Console.ReadLine());

int cherry0 = cherry1;

int MaxSum = cherry1 + cherry2 + cherry3;
for (int i = 3; i < n; i++){
    cherry1 = cherry2;
    cherry2 = cherry3;
    cherry3 = Convert.ToInt32(Console.ReadLine());
    if (cherry1 + cherry2 + cherry3 > MaxSum)
        MaxSum = cherry1 + cherry2 + cherry3;
}
if (cherry0 + cherry2 + cherry3 > MaxSum)
        MaxSum = cherry0 + cherry2 + cherry3;
Console.WriteLine(MaxSum);