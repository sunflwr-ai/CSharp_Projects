using System;

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
        converter.ConvertCurrency();

        UserPreferences preferences = new UserPreferences();
        preferences.GetPreferences();

        NumberComparer nc = new NumberComparer();
        nc.Compare();
        
        Voting v = new Voting();
        v.CheckEligibility();

        MarksHelper m = new MarksHelper();
        m.InputMark();

        SpecifiedOperation so = new SpecifiedOperation();
        so.GetSides();
        so.TestSides();

        Calculator c = new Calculator();
        c.DoMath();


    }
}
