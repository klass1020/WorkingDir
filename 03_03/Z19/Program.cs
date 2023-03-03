string a;
a = Console.ReadLine();
char Pervoe = a[0];
char Vtoroe = a[1];
char Cetvertoe = a[3];
char Pyatoe = a[4];
if( Pervoe == Pyatoe && Vtoroe == Cetvertoe )
{
Console.WriteLine("Palindrom");

}
else
{
    Console.WriteLine("Ne Palindrom");
    
}