// Задача64 Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа  в промежутке от N до 1. Выполнить с пом.рекурсии
// N=5 ->"5, 4, 3, 2, 1"  N = 8 ->"8,7,6,5,4,3,2,1"
/*Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()); 
int count = n;
PrintNamber(count);



void PrintNamber( int count){
    if (count < 1) return;
    Console.Write(count + ";");
    PrintNamber( count - 1);
}
*/
// Задача66
/*Console.WriteLine("Введите начальное число");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int sum = 0;
for(int nach =m;nach <= n; nach++){
sum = sum + nach;
}
Console.WriteLine(sum);
*/

//Задача68
Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
int result = Ank(m, n);
Console.WriteLine(result);

int Ank(int m,int  n){
    if (m == 0){
        return( n+1);
    } 
    else if( n == 0)
    {
        return Ank(m - 1, 1);
    }
    else if ( m> 0 && n >0){
        return Ank( m-1, Ank(m, n - 1));
    }
    return Ank(m, n);
}



