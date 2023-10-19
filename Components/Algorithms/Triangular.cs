using System;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Triangular: Algorithm
    {
        public override string Description { get { return "Triangular numbers calculator"; } }

        private int Calculate(int amount)
        {
            if (amount <= 0) return 0;
            else return amount + Calculate(amount - 1);
        }

        public override void Display()
        {
            int quanity;

            Console.Write("How many triangular numbers do you want to display: ");
            string input = Console.ReadLine();

            bool isNumber = IntParseTest(input);
            if (isNumber) quanity = int.Parse(input);
            else return;

            Console.Write("First "+quanity+" triangular numbers: ");
            for (int i = 0; i < quanity; i++) Console.Write(Calculate(i)+" ");
        }
    }
}
