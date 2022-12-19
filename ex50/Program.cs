void full_matrix(double [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            mtx[i,j] = new Random().NextDouble() * (10 + 10) - 10;
        }
    }
}


Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m,n];
full_matrix(array);

Console.Write("i = ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("j = ");
int j = Convert.ToInt32(Console.ReadLine());

if ((i + 1) > array.GetLength(0) || (j + 1) > array.GetLength(1)) Console.Write("такой позиции в массиве нет");
else Console.Write(array[i,j]);