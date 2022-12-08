void input_random(double[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-1000,1000);
    }
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
double[] array = new double[4];
input_random(array);
double max = -1.79E+308;
double min = 1.79e+308;
for (int i = 0; i < array.Length; i++){
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];
}
Console.WriteLine($"Разница между max и min {max - min}");