using System;

namespace AlgorithmsLibrary.Algorithms
{
    internal class Eratosthenes: Algorithm
    {
        public override string Description { get { return "Sieve of Eratosthenes"; } }

        private int[] calculate(int n)
        {

            bool[] primeBools = new bool[n+1];
            int primeCount = n - 1, primeIndex = 0;

            for (int i = 0; i <= n; i++) primeBools[i] = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    if (primeBools[j])
                    {
                        primeBools[j] = false;
                        primeCount--;
                    }

                }
            }

            int[] primeNumbers = new int[primeCount];

            for (int i = 2; i<=n; i++)
            {
                if (primeBools[i]) primeNumbers[primeIndex++] = i;
            }

            return primeNumbers;
        }

        public override void display()
        {
            int n;

            Console.WriteLine("Algorithm for finding prime numbers from given range [2,n]");
            Console.Write("Enter the value of the n: ");
            string input = Console.ReadLine();

            bool isNumber = intParseTest(input);
            if (isNumber) n = int.Parse(input);
            else return;

            if (n < 2)
            {
                Console.Write("n is less than 2, setting it to 2 instead");
                n = 2;
            }

            int[] res = calculate(n);

            Console.Write("Prime numbers in range [2," + n + "]: ");
            for (int i = 0; i < res.Length; i++) Console.Write(res[i] + " ");
        }
    }
}
