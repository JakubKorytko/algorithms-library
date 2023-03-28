using System;

namespace Algorithms.Modules
{
    internal class Fibonacci: Module
    {
        static private int calculate(int amount)
        {
            if (amount <= 0) return 0;
            else if (amount == 1) return 1;
            else return calculate(amount - 1) + calculate(amount - 2);
        }

        static public void display()
        {
            int quanity;

            Console.Write("How many fibonacci numbers do you want to display: ");
            string input = Console.ReadLine();

            bool isNumber = intParseTest(input);
            if (isNumber) quanity = int.Parse(input);
            else return;

            Console.Write(quanity + " fibonacci numbers: ");
            for (int i = 0; i < quanity; i++) Console.Write(calculate(i) + " ");
        }
    }
}
