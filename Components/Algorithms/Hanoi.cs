using System;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Hanoi: Algorithm
    {
        public override string Description { get { return "Hanoi tower solver"; } }

        private string CreateSteps(int n, char A = 'A', char B = 'B', char C = 'C') {

            if (n > 0)
            {
                string steps;

                char source = A;
                char auxiliary = C;
                char target = B;

                steps = CreateSteps(n - 1, source, auxiliary, target);

                steps += A + " -> " + C + "; ";

                source = B;
                auxiliary = A;
                target = C;

                steps += CreateSteps(n - 1, source, auxiliary, target);


                return steps;
            }

            return "";
        }

        public override void Display()
        {
            int quantity = 1;

            Console.Write("Enter the amount of Hanoi disks: ");
            string input = Console.ReadLine();

            bool isNumber = IntParseTest(input);
            
            if (isNumber) quantity = int.Parse(input);

            if (isNumber && quantity<=0)
            {
                Console.WriteLine("Amount of disks must be greater than 0! Setting it to 1 instead...");
                quantity = 1;
            }

            Console.Write("Steps (assuming that starting position of the disks is tower A and the target position is tower C):\n"+ CreateSteps(quantity));

        }
    }
}
