using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Returning to the menu...");

                Console.ResetColor();
                return false;
            }
        }
    }
}
