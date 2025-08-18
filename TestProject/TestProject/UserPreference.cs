using System;

public class UserPreference
{
    public void GetUserInfo()
    {
        Console.WriteLine("-- User Information --");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your favorite hobby: ");
        string hobby = Console.ReadLine();
    
        Console.WriteLine($"\n--- Your Introduction ---");
        Console.WriteLine($"Hi, my name is {name}.");
        Console.WriteLine($"I'm {age} years old.");
        Console.WriteLine($"I love {hobby}.");
    }
}
