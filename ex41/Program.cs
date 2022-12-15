Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
int n = 0;
for (int i = 0; i < m; i++){
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if(n > 0){
        count++;
    }
}
Console.WriteLine(count);