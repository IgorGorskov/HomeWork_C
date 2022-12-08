// Гипотеза Гольдбаха

bool is_simple(int n){
    for (int i = 2; i < n; i++){
        if (n % i == 0)
            return false;
    }
    return true;
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 3; i < n; i++){
    if(is_simple(i) && is_simple(n - i)){
        Console.Write($"{i}, {n - i}");
        break;
    }
}