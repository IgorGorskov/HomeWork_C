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

Console.WriteLine("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] mtx = new int[m,n];
full_matrix(mtx);
output_matrix(mtx);
int [] ans = new int[m];
int sum = 0;
for (int i = 0; i < mtx.GetLength(0); i++){
    for (int j = 0; j < mtx.GetLength(1); j++){
        sum = sum + mtx[i,j];
    }
    ans[i] = sum;
    sum = 0;
}
int min = 1000000000;
int count = 0;

for (int i = 0; i < ans.GetLength(0); i++){
    if(ans[i] < min){
        min = ans[i];
        count = i;
    }
}
Console.WriteLine();
Console.WriteLine($"{count + 1} строка");