void output_matrix(int [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            Console.Write($"{mtx[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void full_matrix(int [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            mtx[i,j] = new Random().Next(1,100);
        }
    }
}

int [,] matrix = new int[4,3];

full_matrix(matrix);
output_matrix(matrix);
int [,] matrix_ans = new int[4,3];

int cont;

for(int i = 0; i < 4; i++){
    for(int j = 0; j < 3; j++){
        for(int k = 0; k < 2; k++){
            if(matrix[i,k] < matrix[i, k + 1]){
                cont = matrix[i,k];
                matrix[i,k] = matrix[i, k + 1];
                matrix[i, k + 1] = cont;
            }
        }
    }
}

Console.WriteLine();
output_matrix(matrix);
