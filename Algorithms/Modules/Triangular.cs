using System;

namespace Algorithms.Modules
{
    internal class Triangular: Module
    {
        static private int calculate(int amount)
        {
            if (amount <= 0) return 0;
            else return amount + calculate(amount - 1);
        }

        static public void display()
        {
            int quanity;

            Console.Write("How many triangular numbers do you want to display: ");
            string input = Console.ReadLine();

            bool isNumber = intParseTest(input);
            if (isNumber) quanity = int.Parse(input);
            else return;

            Console.Write("First "+quanity+" triangular numbers: ");
            for (int i = 0; i < quanity; i++) Console.Write(calculate(i)+" ");
        }
    }
}
