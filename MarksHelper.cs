using System;

public class MarksHelper
{
    public double InputMark(int number)
    {
        string subject = number switch
        {
            1 => "Math",
            2 => "Science",
            3 => "English",
            _ => "Unknown"
        };

        Console.Write("Enter marks for " + subject + ": ");
        return double.Parse(Console.ReadLine());
    }
}
