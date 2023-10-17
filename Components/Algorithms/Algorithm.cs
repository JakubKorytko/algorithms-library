using System;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Algorithm
    {
        static public bool intParseTest(string num)
        {

            bool isNumber = int.TryParse(num, out int n);

            if (isNumber == false)
            {
                Console.Write("You must enter a number!");
            }

            return isNumber;

        }
    }
}
