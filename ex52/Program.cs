void full_matrix(double [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            mtx[i,j] = new Random().NextDouble() * (10 + 10) - 10;
        }
    }
}

void output_array(double [] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        Console.Write($"{Math.Round(mtx[i], 2)} \t");

    }
}

void output_matrix(double [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            Console.Write($"{Math.Round(mtx[i,j], 2)} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [m,n];
full_matrix(matrix);
double [] average = new double [n];
double sum = 0;

for (int j = 0; j < matrix.GetLength(1); j++){
    for (int i = 0; i < matrix.GetLength(0); i++){
        sum = sum + matrix[i,j];
    }
average[j] = sum / n;
}
output_matrix(matrix);
Console.WriteLine();
output_array(average);