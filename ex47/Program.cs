void full_matrix(double [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(0); j++){
            mtx[i,j] = new Random().NextDouble() * (10 + 10) - 10;
        }
    }
}

void output_matrix(double [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(0); j++){
            Console.Write($"{Math.Round(mtx[i,j], 2)} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m,n];

full_matrix(array);

output_matrix(array);