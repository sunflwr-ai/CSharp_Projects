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

    }
}
