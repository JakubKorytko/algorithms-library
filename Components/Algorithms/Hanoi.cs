using System;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Hanoi: Algorithm
    {
        static private string createSteps(int n, char A = 'A', char B = 'B', char C = 'C') {
               
            if (n > 0)
            {
                string steps;
                steps = createSteps(n - 1, A, C, B);
                steps += A+" -> "+C+"; ";
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
