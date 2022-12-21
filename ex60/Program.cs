int [,,] matrix = new int [3,3,3];
int n = 11;
for (int i = 0; i < 3; i++){
    for (int j = 0; j < 3; j++){
        for (int k = 0; k < 3; k++){
            matrix[i,j,k] = n;
            n++;
            Console.Write($"{matrix[i,j,k]}({i},{j},{k})");
        }
        Console.Write(" , ");
    }
    Console.WriteLine();
}