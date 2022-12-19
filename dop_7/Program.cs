//Транспонирование 
void output_array(int [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            Console.Write($"{mtx[i,j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
for (int i = 0; i < array.GetLength(0); i++){
    string [] num = Console.ReadLine().Split(" ");
    for(int j = 0; j < array.GetLength(1); j++){
        array[i,j] = Convert.ToInt32(num[j]);
    }
}

output_array(array);
int buf;
for (int i = 0; i < array.GetLength(0) / 2; i++){
    for(int j = 0; j < array.GetLength(1); j++){
        buf = array[i,j];
        array[i,j] = array[m - i - 1,j];
        array[m - i - 1,j] = buf;
    }
}
output_array(array);