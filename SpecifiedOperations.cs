/*
 WAP in C# to test if the input sides are valid side of triangle or not .Also display the area of triangles.
If the input sides are valid.
*/

using System;
public class SpecifiedOperation
{
    public void GetSides()
    {
        Console.Write("Enter side 1 : ");
        double a = Convert.ToDouble(Console.Read());
        Console.Write("Enter side 2 : ");
        double b = Convert.ToDouble(Console.Read());
        Console.Write("Enter side 3 : ");
        double c = Convert.ToDouble(Console.Read());
    }

    public void TestSides()
    {
 if (IsValidTriangle( a , b , c ))
        {
            Console.WriteLine("These sides form a valid triangle.");
        }
        else
        {
            Console.WriteLine("These sides do NOT form a valid triangle.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
