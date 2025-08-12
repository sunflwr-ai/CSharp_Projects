using System;

class AverageMarks
{
    public void Marks()
    {
        double sum = 0;

        for (int m = 1; m <= 5; m++)
        {
            switch (m)
            {
                case 1:
                    Console.Write("Enter marks for subject 1: ");
                    break;
                case 2:
                    Console.Write("Enter marks for subject 2: ");
                    break;
                case 3:
                    Console.Write("Enter marks for subject 3: ");
                    break;
                case 4:
                    Console.Write("Enter marks for subject 4: ");
                    break;
                case 5:
                    Console.Write("Enter marks for subject 5: ");
                    break;
            }
            sum += Convert.ToDouble(Console.ReadLine());
        }

        double avg = sum / 5;
        Console.WriteLine("Average marks = " + avg);
    }
}
