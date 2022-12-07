Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
while(B != 0){
    result = result * A;
    B--;
}
Console.WriteLine(result);