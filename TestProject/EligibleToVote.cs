using System;

class EgibleToVote
{
    public void Age()
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
    }
        public bool IsEligible()
    {
        return age >= 18;
    }
}

