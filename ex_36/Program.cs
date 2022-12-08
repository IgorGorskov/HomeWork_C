void input_random(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-1000,1000);
    }
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}

int[] array = new int[4];
input_random(array);
int sum = 0;

for (int i = 1; i < array.Length; i = i + 2)
    sum = sum + array[i];
Console.WriteLine($"Сумма нечетных: {sum}");