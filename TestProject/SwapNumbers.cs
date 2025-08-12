using System;

public class SwapNumbers
{
    public int num1, num2;

    public void GetNumbers()
    {
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
    }

    public void Swap()
    {
        int t = num1;
        num1 = num2;
        num2 = t;
    }

    public void Display()
    {
        Console.WriteLine($"After swapping:\nFirst Number: {num1}\nSecond Number: {num2}");
    }
}
