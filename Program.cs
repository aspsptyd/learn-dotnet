using System;

class Program
{
    static void Main()
    {
        // Output to console basic text
        // Console.WriteLine(TextHello());

        // Output  get datetime to console
        // Console.WriteLine(GetDateSystem());
        
        // Input from user
        Console.WriteLine(InputFromUser());
    }

    static String TextHello() {
        return "Hello World!";
    }

    static String GetDateSystem() {
        DateTime getDateBySystem = DateTime.Now;
        return "Date now: " + getDateBySystem;
    }

    static String InputFromUser() {
        Console.Write("Type your name: ");
        var name = Console.ReadLine();
        return "Hi, " + name;
    }
}