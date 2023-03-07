
int GetSum(int n){
    int sum = 0;
    for (int i = 0; i <= n; i++)
        sum += i; // sum = sum + i
    return sum;
}


Console.Write( "Введите число : ");
int n = int.Parse(Console.ReadLine());
//int sum = GetSum (n);
Console.WriteLine($"Сумма от 1 до {n} равна {GetSum (n)}");
