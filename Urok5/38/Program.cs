int[] array = new int[5];
int max = int.MinValue;
int min = int.MaxValue;

for ( int i = 0; i < 5; i ++)
{
    Console.Write($"Введите {i} элемент ");
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > max)
    {
        max = array[i];

    }
    if (array[i] < min){
        min = array[i];
    }
}
Console.WriteLine("Разница: " + (max - min));