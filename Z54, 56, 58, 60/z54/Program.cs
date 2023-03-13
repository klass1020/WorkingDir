int[,] array = {{1, 4, 7, 2},
               {5, 9, 2, 3},
                {8, 4, 2, 4}};
 for( int row = 0; row < array.GetLength(0); row++)
{ 
    for( int collumn = 0; collumn < array.GetLength(1); collumn++)
    {
      for( int collum1 = collumn; collum1 < array.GetLength(1); collum1 ++)
      {
          if (array[row, collumn] < array[row, collum1])
          {
            int sol =array[row, collumn];
            array[row, collumn] = array[row, collum1];
            array[row, collum1] = sol;

          }

      }


    }

}
for( int row = 0; row < array.GetLength(0); row++)
{

    for( int collumn = 0; collumn < array.GetLength(1); collumn++)
    {
      Console.Write(array[row, collumn]);
    }
      Console.WriteLine();
}               