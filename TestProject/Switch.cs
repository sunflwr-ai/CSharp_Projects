using System;

class Switch
{
    public void Display()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: "); 
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool valid = true;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    valid = false;
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;

            default:
                valid = false;
                Console.WriteLine("Invalid operator.");
                break;
        }

        if (valid)
            Console.WriteLine("Result: " + result);
    }
}
