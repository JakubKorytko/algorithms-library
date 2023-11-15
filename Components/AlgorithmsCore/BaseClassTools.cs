using System;

namespace AlgorithmsLibrary.AlgorithmsCore
{
    internal class BaseClassTools
    {
        protected bool IntParseTest(string num)
        {

            bool isNumber = int.TryParse(num, out int _);

            return isNumber;

        }

        protected bool IntParseTestWithOutput(string num)
        {
            bool testResult = IntParseTest(num);
            if (testResult)
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please provide a valid integer number\n");

                Console.ResetColor();
                Console.Write("Returning to the menu...");

                return false;
            }
        }

        // example of the method to use across algorithms
        // you can use any return type or method name
        protected int OnePlusOne()
        {
            return 1 + 1;
        }
    }
}
