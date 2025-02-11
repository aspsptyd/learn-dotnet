## Project Base Learn .NET Console
Project console .NET basic from 0 to hero

## a. Store, Retrieve Data using Literal & Variable Value

```.cs
string name = "Bob";
int value = 3;
float temperature = 34.4f;

Console.WriteLine($"Hello, {name}! You have {value} messages in your inbox. The temperature is {temperature} celsius.");
```

```.cs
decimal value = 3.14159265359m;
double radius = 2.5323;

Console.WriteLine($"The value of Pi is approximately {value}.");
Console.WriteLine($"The radius of the circle is {radius}.");
```

```.cs
bool isStatus = false;
int age = 20;
if (age >= 18) {
    isStatus = true;
}

Console.WriteLine($"Is the person {age} years old, an adult? {isStatus}");
```