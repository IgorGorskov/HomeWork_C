void input_random(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100,1000);
    }
}


Console.Write("Массив: ");
int[] array = new int[4];
input_random(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int counter = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0)
        counter++;
}
Console.WriteLine($"Количество четных в массиве: {counter}");
