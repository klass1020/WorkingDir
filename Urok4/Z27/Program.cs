
Console.WriteLine("Введите число");
int number = int.Parse ( Console.ReadLine());
int summa = 0;
while ( number != 0)
{
 summa += number % 10;
 number = number / 10;

}
Console.WriteLine("Сумма чисел" + summa );

