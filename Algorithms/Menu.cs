using System;
using AlgorithmsLibrary.Algorithms;

namespace AlgorithmsLibrary
{
    internal class Menu
    {

        static public string options =
            "What program would you like to use? Available options:\n\n"
            + "hanoi - Hanoi tower solver\n"
            + "fibonacci - Fibonacci sequence calculator\n"
            + "triangular - Triangular numbers calculator\n"
            + "factorial - Factorial calculator\n"
            + "eratosthenes - Sieve of Eratosthenes\n\n"
            + "Enter 'menu' to display this menu again\n"
            + "Enter 'exit' to end the program...";


        public static string input()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("select> ");
            string option = Console.ReadLine().Trim();
            Console.WriteLine();
            Console.ResetColor();

            return option;
        }

        public static void display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(options);
            Console.ResetColor();
        }

        public static void error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("You chose wrong option from the menu! (enter 'menu' to display menu again)");
            Console.ResetColor();
        }
        public static bool select(string n)
        {
            switch (n)
            {
                case "hanoi":
                    Hanoi.display();
                    break;
                case "fibonacci":
                    Fibonacci.display();
                    break;
                case "triangular":
                    Triangular.display();
                    break;
                case "factorial":
                    Factorial.display();
                    break;
                case "eratosthenes":
                    Eratosthenes.display();
                    break;
                case "menu":
                    display();
                    break;
                case "exit":
                    return false;
                default:
                    error();
                    break;
            }
            Console.WriteLine("\n");
            return true;
        }
    }
}
