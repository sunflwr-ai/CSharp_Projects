/*
 WAP in C# to test if the input sides are valid side of triangle or not .Also display the area of triangles.
If the input sides are valid.
*/
using System;

class SpecifiedOperation
{
    public void Operation()
    {
        Console.Write("Enter side a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Valid triangle.");

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Area = " + area);
        }
        else
        {
            Console.WriteLine("Not a valid triangle.");
        }
    }
}

