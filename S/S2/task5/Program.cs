

Console.Clear();

int count = 1;
while(count <= 100)
{
    if(( count % 3 == 0) && ( count % 5 == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.Write("FizzBuzz");
    }else if( count % 3 == 0) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.Write("Fizz");
    }else if( count % 5 == 0) 
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.Write("Buzz");
    }else  
    {
        System.Console.Write(count);
    }
    Console.ForegroundColor = ConsoleColor.White;
    if( count == 100) 
    {
        System.Console.Write(".");
    }else  
    {
        System.Console.Write(", ");
    }
    count++;
}