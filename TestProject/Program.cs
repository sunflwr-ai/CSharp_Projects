using System;
using ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        SwapNumbers sn = new SwapNumbers();
        sn.GetNumbers();
        sn.Swap();
        sn.Display();
        Console.ReadLine();

        Multiplication m = new Multiplication();
        m.GetNumbers();

        int result = m.Multiply();
        Console.WriteLine("Multiplication result: " + result);
        Console.ReadLine();

        MyInfo info = new MyInfo();
        info.Details();
        Console.ReadLine();

        CurrencyConverter converter = new CurrencyConverter();
        converter.RunConverter();

        UserPreference preferences = new UserPreference();
        preferences.GetUserInfo();


        NumberComparer nc = new NumberComparer();
        nc.Compare();

        EligibleToVote vote = new EligibleToVote();
        vote.Vote();

        SpecifiedOperation so = new SpecifiedOperation();
        so.Operation();


        Pattern p = new Pattern();
        p.Pattern_Display();

        Switch s = new Switch();
        s.Display();

        AverageMarks am = new AverageMarks();
        am.Marks();













    }
}
