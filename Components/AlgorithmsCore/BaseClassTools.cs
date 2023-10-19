using System;

namespace AlgorithmsLibrary.AlgorithmsCore
{
    internal class BaseClassTools
    {
        public bool IntParseTest(string num)
        {

            bool isNumber = int.TryParse(num, out int _);

            return isNumber;

        }

        public bool IntParseTestWithOutput (string num)
        {
            bool testResult = IntParseTest(num);
            if (testResult)
            {
                return true;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please provide a valid integer number\n");

                Console.ResetColor();
                Console.Write("Returning to the menu...");

                return false;
            }
        }
    }
}
