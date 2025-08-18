using System;

namespace ConsoleApp1
{
    class Voting
    {
        public static void CheckEligibility()
        {
            Console.WriteLine("\n-- Voting Eligibility --");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("You can vote.");
            else
                Console.WriteLine("You are not old enough to vote.");
        }
    }
}
