using System;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Factorial: Algorithm
    {
        public override string Description { get { return "Factorial calculator"; } }

        private UInt64 calculate(int amount)
        {
            UInt64 longAmount = (UInt64)amount;

            if (amount <= 0) return 1;
            else return longAmount * calculate(amount - 1);
        }

        public override void display()
        {
            int quanity;

            Console.Write("What factorial do you want to display: ");
            string input = Console.ReadLine();

            bool isNumber = intParseTest(input);
            if (isNumber) quanity = int.Parse(input);
            else return;

            Console.Write("Factorial of " + quanity + ": " + calculate(quanity));
        }
    }
}
