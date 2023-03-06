
Console.WriteLine("Введите число");
int numer = int.Parse (Console.ReadLine());
Console.Write("Введите степень");
int stepen = int.Parse (Console.ReadLine());
int resultat = 1 ;
for (int i = 0; i < stepen; i++ )
{
    resultat = resultat*numer;
}
Console.WriteLine("Степень числа" + resultat);



