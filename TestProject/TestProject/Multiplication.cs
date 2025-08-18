using System;

public class Multiplication
{
    public int num1, num2, num3;

    public void GetNumbers()
    {
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());
    }

    public int Multiply()
    {
        return num1 * num2 * num3;
    }
}
