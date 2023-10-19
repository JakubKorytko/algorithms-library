using System;
using AlgorithmsLibrary.AlgorithmsCore;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Factorial: Algorithm
    {
        public override string Description { get { return "Factorial calculator"; } }

        private UInt64 Calculate(int amount)
        {
            UInt64 longAmount = (UInt64)amount;

            if (amount <= 0) return 1;
            else return longAmount * Calculate(amount - 1);
        }

        public override void Display()
        {
            int quanity;

            Console.Write("What factorial do you want to display: ");
            string input = Console.ReadLine();

            bool isNumber = IntParseTest(input);
            if (isNumber) quanity = int.Parse(input);
            else return;

            Console.Write("Factorial of " + quanity + ": " + Calculate(quanity));
        }
    }
}
