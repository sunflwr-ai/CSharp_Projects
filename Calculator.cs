using System;

namespace ConsoleApp1
{
    public class Calculator
    {
        public static void DoMath()
        {
            Console.WriteLine("\n-- Basic Calculations --");
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add: " + (x + y));
            Console.WriteLine("Subtract: " + (x - y));
            Console.WriteLine("Multiply: " + (x * y));
            if (y != 0)
            {
                Console.WriteLine("Divide: " + (x / y));
                Console.WriteLine("Modulus: " + (x % y));
            }
            else
            {
                Console.WriteLine("Cannot divide or mod by zero.");
            }
        }
    }
}
