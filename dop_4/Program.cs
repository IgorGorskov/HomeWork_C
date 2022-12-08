// Статистика
void input_dates(int[] array){
    Console.WriteLine("Введите даты(дни) урока английского");
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите кол-во оценок");
int n = Convert.ToInt32(Console.ReadLine());
int[] date = new int [n];
input_dates(date);

int counter_b = 0;
int counter_c = 0;

for (int i = 0; i < date.Length; i++){
    if (date[i] % 2 == 0)
        counter_b++;
    else
        counter_c++;
}
int[] date_b = new int [counter_b];
int[] date_c = new int [counter_c];

int b = 0;
int c = 0;

for (int i = 0; i < date.Length; i++){
    if (date[i] % 2 == 0){
        date_b[b] = date[i];
        b++;
    }
    else{
        date_c[c] = date[i];
        c++;
    }
}
Console.WriteLine($"[{string.Join(", ", date_c)}]");
Console.WriteLine($"[{string.Join(", ", date_b)}]");

if (counter_b > counter_c)  //обычно для "4" нужно 3,6 и выше, потому при равенстве оценок будет "3".
    Console.WriteLine("YES");
else    
    Console.WriteLine("NO");