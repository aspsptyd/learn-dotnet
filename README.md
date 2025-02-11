## Project Base Learn .NET Console
Project console .NET basic from 0 to hero

## a. Store, Retrieve Data using Literal & Variable Value

```.cs
string name = "Bob";
int value = 3;
float temperature = 34.4f;

Console.WriteLine($"Hello, {name}! You have {value} messages in your inbox. The temperature is {temperature} celsius.");
```

![Screenshot 2025-02-11 at 23 54 13](https://github.com/user-attachments/assets/13be9a34-0abc-4e8e-b0e5-e3813e5557fb)


```.cs
decimal value = 3.14159265359m;
double radius = 2.5323;

Console.WriteLine($"The value of Pi is approximately {value}.");
Console.WriteLine($"The radius of the circle is {radius}.");
```

![Screenshot 2025-02-11 at 23 54 49](https://github.com/user-attachments/assets/db3b66de-2428-4e46-8229-911b6b5ff2a8)


```.cs
bool isStatus = false;
int age = 20;
if (age >= 18) {
    isStatus = true;
}

Console.WriteLine($"Is the person {age} years old, an adult? {isStatus}");
```

![Screenshot 2025-02-11 at 23 55 12](https://github.com/user-attachments/assets/ea41a4f1-55f6-4133-b6b0-4f859ed74ba5)
