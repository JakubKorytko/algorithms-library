using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Modules
{
    internal class Hanoi: Module
    {
        static private string createSteps(int n, char A = 'A', char B = 'B', char C = 'C') {
               
            if (n > 0)
            {
                string steps;
                steps = createSteps(n - 1, A, C, B);
                steps += A+" -> "+B+"; ";
                steps += createSteps(n - 1, B, A, C);

                return steps;
            }
            return "";
        }

        static public void display()
        {
            int quantity = 1;

            Console.Write("Enter the amount of Hanoi disks: ");
            string input = Console.ReadLine();

            bool isNumber = intParseTest(input);
            
            if (isNumber) quantity = int.Parse(input);

            if (isNumber && quantity<=0)
            {
                Console.WriteLine("Amount of disks must be greater than 0! Setting it to 1 instead...");
                quantity = 1;
            }

            Console.Write("Steps (assuming that starting position of the disks is tower A and the target position is tower C):\n"+createSteps(quantity));

        }
    }
}
