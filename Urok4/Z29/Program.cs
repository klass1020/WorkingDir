int[] array = new int[8];
for( int i = 0; i < 8; i++)
{
    Console.Write("Введите " + i + "Элемент");
    array[i] = int.Parse( Console.ReadLine());

}
for (int i = 0; i < 8; i++)
{
    Console.Write(array[i] + " ");
    
}