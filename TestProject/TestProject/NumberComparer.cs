using System;

    public class NumberComparer
    {
        public void Compare()
        {
            Console.WriteLine("\n-- Compare Two Numbers --");
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine(a + " is greater.");
            else if (b > a)
                Console.WriteLine(b + " is greater.");
            else
                Console.WriteLine("Both are equal.");
        }
    }

