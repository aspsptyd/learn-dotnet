using System;

class Program
{
    static void Main()
    {
        // Call the Function method Type here
        ThirdStage();
    }

    static void FirstStage() {
        Console.WriteLine("Hello\nWorld!");
        Console.WriteLine("Hello\tWorld!");
    }

    static void SecondStage() {
        Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
    }

    static void ThirdStage() {
        Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
    }
}