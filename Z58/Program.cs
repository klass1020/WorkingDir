// Задайте две матрицы. Напишите программму, которая будет находить произведение двух матриц
// Например, даны две матрицы: 2 4| 3 4
                           //  3 2| 3 3  Результирующая матрица будет: 18 | 20
                           //                                         15 | 18
int[,] array1 = {{ 2, 4}, {3, 2}};
int[,] array2 = {{3, 4}, {3, 3}};   
int num1 = (array1[0, 0]* array2[0, 0]) +(array1[0, 1]* array2[1, 0]);
int num2 = (array1[1, 0]* array2[0, 0]) +(array1[1, 1]* array2[1,0]);  
int num3 = (array1[0, 0]* array2[0,1]) + (array1[0, 1]* array2[1, 1]);
int num4 = (array1[1, 0]* array2[0, 1]) + (array1[1, 1]* array2[1,1]);       
Console.WriteLine(num1+" " + num3 );
Console.WriteLine(num2+" " + num4);