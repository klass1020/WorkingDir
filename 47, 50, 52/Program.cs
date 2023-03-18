// Задайте двумерный массив размером mxn, заполненный случайными веществен.числами;
/*
int m = 3;
int n = 4;


double[,] array = new double[m, n];
FillArray(array);
Print(array);
void FillArray(double[,] matr){
    for( int i = 0; i < matr.GetLength(0); i++){
        for( int j = 0; j < matr.GetLength(1); j++){
            matr[i,j] = new Random().NextDouble();
        }
    }
}
void Print(double[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
         Console.Write($" {matr [i,j]} ");
        }
    }
    Console.WriteLine();
}
*/
// Задача 50
/*double[,] array = new double[4, 3];
int row = int.Parse(Console.ReadLine());
int collumn = int.Parse(Console.ReadLine());
FillArray(array);
Print(array);
if ( row > 3 || collumn > 2){
    Console.WriteLine("Такого элемента нет");
}
else{
    Console.WriteLine(array[row, collumn]);
}
void FillArray(double[,] matr){
    for( int i = 0; i < matr.GetLength(0); i++){
        for( int j = 0; j < matr.GetLength(1); j++){
            matr[i,j] = new Random().NextDouble();
        }
    }
}
void Print(double[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
         Console.Write($" {matr [i,j]} ");
        }
    }
    Console.WriteLine();
}
*/
// Задача 52
int[,] a = new int[,]{{1, 4, 7, 2}, {5,9,2,3},{8,4,2,4} };
for (int collumn = 0;collumn < a.GetLength(1);collumn++)
{
    double sum = 0; 
    for (int row = 0; row < a.GetLength(0); row++){
    sum += a[row, collumn];

    }
    Console.WriteLine(sum/3);
}
