﻿using System;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Fibonacci: Algorithm
    {
        public override string Description { get { return "Fibonacci sequence calculator"; } }

        private int calculate(int amount)
        {
            if (amount <= 0) return 0;
            else if (amount == 1) return 1;
            else return calculate(amount - 1) + calculate(amount - 2);
        }

        public override void display()
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