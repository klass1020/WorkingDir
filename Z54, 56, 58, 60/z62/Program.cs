int [,] array = new int[4,4];
int num = 1;
for (int i =0; i < 4; i++)
{
    array[0, i] = num;
    num = num +1;

}
for(int j = 1; j < 4; j++){
    array[j, 3] = num;
    num = num +1;

}
for (int k = 2; k >=0; k--){
array[3,k] = num;
num = num +1;
}
for(int l = 2; l >=1; l--){
    array[l, 0] = num;
    num = num + 1;

}
for(int m = 1; m <=2; m++){
    array[1, m] = num;
    num = num + 1;

}
for(int r = 2; r >= 1; r--){
    array[2, r] = num;
    num = num +1;
}
for(int row = 0; row < 4; row++){
    for(int collum = 0; collum < 4; collum++){
        Console.Write(array[row, collum] +" ");
    }
    Console.WriteLine();
}








