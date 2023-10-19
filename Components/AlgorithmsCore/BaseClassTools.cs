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

            if (!isNumber)
            {
                Console.Write("You must enter a number!");
            }

            return isNumber;

        }
    }
}
