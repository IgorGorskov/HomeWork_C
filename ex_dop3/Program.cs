Console.WriteLine("Введите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++){
    Console.Write("Введите элемент массива: ");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}
Console.WriteLine("Введите сдвиг");
int shift = Convert.ToInt32(Console.ReadLine());

if (shift > n)
    shift = shift % n;
if (shift < 0)
    shift = n + shift + 2;
int[] array_new = new int[n];

for(int i = 0; i < n; i++)
{
    if (shift + i > n)
        array_new[i] = array[i + shift - 1 - n];
    else
        array_new[i] = array[i + shift - 1];
}
Console.WriteLine($"[{string.Join(", ", array_new)}]");