using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Modules
{
    internal class Module
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
