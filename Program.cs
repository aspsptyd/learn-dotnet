using System;

class Program
{
    static void Main()
    {
        // Output to console basic text
        Console.WriteLine("Hello World!");

        // Output  get datetime to console
        Console.WriteLine("Date now: " + DateTime.Now);
        
        // Input from user
        var name = Console.ReadLine();
        // Output to console
        Console.WriteLine("Hi, " + name);
    }
}