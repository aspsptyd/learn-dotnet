using System;

class Program
{
    static void Main()
    {
        // Call the Function method Type here
        ThirdStage();
    }

    static void FirstStage() {
        string name = "Bob";
        int value = 3;
        float temperature = 34.4f;

        Console.WriteLine($"Hello, {name}! You have {value} messages in your inbox. The temperature is {temperature} celsius.");
    }

    static void SecondStage() {
        decimal value = 3.14159265359m;
        double radius = 2.5323;

        Console.WriteLine($"The value of Pi is approximately {value}.");
        Console.WriteLine($"The radius of the circle is {radius}.");
    }

    static void ThirdStage() {
        bool isStatus = false;
        int age = 20;
        if (age >= 18) {
            isStatus = true;
        }

        Console.WriteLine($"Is the person {age} years old, an adult? {isStatus}");
    }
}