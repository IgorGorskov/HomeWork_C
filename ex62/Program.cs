void output_matrix(int [,] mtx){
    for (int i = 0; i < mtx.GetLength(0); i++){
        for (int j = 0; j < mtx.GetLength(1); j++){
            Console.Write($"{mtx[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] mtx = new int[4,4]; // не смог решить
mtx[0,0] = 1;
mtx[0,1] = 2;
mtx[0,2] = 3;
mtx[0,3] = 4;
mtx[1,3] = 5;
mtx[2,3] = 6;
mtx[3,3] = 7;
mtx[3,2] = 8;
mtx[3,1] = 9;
mtx[3,0] = 10;
mtx[3,0] = 10;
mtx[2,0] = 11;
mtx[1,0] = 12;
mtx[1,1] = 13;
mtx[1,2] = 14;
mtx[2,2] = 15;
mtx[2,1] = 16;
output_matrix(mtx);
