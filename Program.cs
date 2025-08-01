using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            CurrencyConverter.RunConverter();
            NumberComparer.Compare();
            Calculator.DoMath();
            UserPreference.GetUserInfo();
            Voting.CheckEligibility();
            CurrencyConverter.RunConverter();

            MarksHelper helper = new MarksHelper();

        double mark1 = helper.InputMark(1);
        double mark2 = helper.InputMark(2);
        double mark3 = helper.InputMark(3);

        double average = (mark1 + mark2 + mark3) / 3;

        Console.WriteLine("Average Marks: " + average);
        }
    }
}
