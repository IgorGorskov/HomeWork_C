int sum(int m, int n){
    if (m + 1 == n)
        return m + n;
    return sum(m + 1, n) + m;
}
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sum(m, n));