int[,] array = {{1, 4, 7, 2}, 
                 {5,9,2,3},
                 {8,4 , 2,4},
                  {5,2,6,7}};
 int summ = 0, minSum = 40 , namrow = 0; // Задали сумму, минсумму и номер строки = 0           
for( int row = 0; row < array.GetLength(0); row++)
{

    summ = 0;
    
    for( int collumn = 0; collumn < array.GetLength(1); collumn++)
    {
      Console.Write(array[row, collumn]);
      summ += array[row, collumn];      //Прибавили к сумме элемент строки;
    }
      if(summ < minSum){
      minSum = summ;
      namrow = row ;         //Запомнили/задали номер строки,где нашли минсумму;
      }

      
      Console.WriteLine();
} 
    Console.WriteLine("Минимальная сумма: "+ minSum);
    Console.WriteLine("Строка с минимальной суммой: "+ namrow);             
