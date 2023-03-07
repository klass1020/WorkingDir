int[] array = new int[4];
int chetnoe = 0; // задали переменную для счетчика
for (int i = 0; i < 4; i++)

{
    Random rnd = new Random();
    array[i] = rnd.Next(100, 1000);
    Console.WriteLine(array[i]);
    if( array[i] % 2 == 0 )
    {
        chetnoe ++;
    }
}
Console.WriteLine(chetnoe);