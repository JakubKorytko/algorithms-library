using System;
using AlgorithmsLibrary.AlgorithmsCore;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Fibonacci: Algorithm
    {
        public override string Description { get { return "Fibonacci sequence calculator"; } }

        private int Calculate(int amount)
        {
            if (amount <= 0) return 0;
            else if (amount == 1) return 1;
            else return Calculate(amount - 1) + Calculate(amount - 2);
        }

        public override void Display()
        {
            int quanity;

            Console.Write("How many fibonacci numbers do you want to display: ");
            string input = Console.ReadLine();

            bool isNumber = IntParseTestWithOutput(input);

            if (!isNumber)
            {
                return;
            }

            quanity = int.Parse(input);

            Console.Write(quanity + " fibonacci numbers: ");
            for (int i = 0; i < quanity; i++) Console.Write(Calculate(i) + " ");
        }
    }
}
