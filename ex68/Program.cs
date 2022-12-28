int acerman(int m, int n){
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return acerman(m - 1, 1);
    if ((m > 0) && (n > 0)) return acerman(m - 1, acerman(m, n - 1));
    else return 0;
}

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(acerman(m, n));