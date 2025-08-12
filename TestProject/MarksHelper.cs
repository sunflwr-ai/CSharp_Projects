using System;

public class MarksHelper
{
    public float InputMark(int n)
    {
        string subject = n switch
        {
            1 => "Math",
            2 => "Science",
            3 => "English",
            _ => "Subject"
        };

        Console.Write($"Enter marks for {subject}: ");
        return float.Parse(Console.ReadLine());
    }
}
