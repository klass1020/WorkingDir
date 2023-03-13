//Массив размером 2х2х2  66(0,0,0)
int [,,] array = {{{66, 27}, {25,90}}, 
                 {{34,26}, {41, 55}}};
for(int izm = 0; izm < 2; izm++) //izm -измерение/глубина массива;
{
 for(int row = 0; row < 2; row++){
    for(int collum = 0;collum < 2; collum++){
        Console.Write(array[izm, row, collum]+" ( "+ izm+ ","+row+ ","+collum+ ") " );
    }
    Console.WriteLine();
 }
Console.WriteLine();    
}                 
