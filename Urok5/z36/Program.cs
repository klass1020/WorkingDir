int[] array = new int[4];
int summa = 0; // задали переменную для хранения суммы
for (int i = 0; i < 4; i++)

{
    Random rnd = new Random(); // создали объект генератора случайных чисел
    array[i] = rnd.Next(0, 100);  // генерируем случайное число в диап от 0 до 100, записываем его в масс под индексом i
    Console.WriteLine(array[i]);
    if( i % 2!= 0 )
    {
        summa = summa + array[i];
    }
}
Console.WriteLine(" Сумма: " + summa); 
