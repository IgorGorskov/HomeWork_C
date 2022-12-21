void output_matrix(int [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            Console.Write($"{mtx[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void full_matrix(int [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            mtx[i,j] = new Random().Next(1,100);
        }
    }
}

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] mtx1 = new int[m,n];
full_matrix(mtx1);
output_matrix(mtx1);
int [,] mtx2 = new int[m,n];

full_matrix(mtx2);
output_matrix(mtx2);
int [,] ans = new int[m,n];

for(int i = 0; i < mtx1.GetLength(0); i++){
    for(int j = 0; j < mtx1.GetLength(1); j++){
    ans[i,j] = mtx1[i,j] * mtx2[i,j];
    }
}
Console.WriteLine("result:");
output_matrix(ans);