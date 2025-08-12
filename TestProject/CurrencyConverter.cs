using System;

namespace ConsoleApp1
{
    public class CurrencyConverter
    {
        public  void RunConverter()
        {
            Console.WriteLine("\n-- Currency Converter --");
            Console.Write("Enter USD amount: ");
            double usd = System.Convert.ToDouble(Console.ReadLine());

            double rate = 133.5;
            double npr = usd * rate;
            Console.WriteLine("In NPR: " + npr);
        }
    }
}
