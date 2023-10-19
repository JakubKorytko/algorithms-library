using System;
using System.Linq;
using System.Collections.Generic;
using AlgorithmsLibrary.Algorithms;

namespace AlgorithmsLibrary
{
    internal class Menu
    {

        private static AlgorithmObject[] algorithms;
        static private string options;

        static public void Run()
        {
            SetAlgorithmsIfEmpty();
            GenerateOptions();
            Menu.select("menu");
        }

        static private void SetAlgorithmsIfEmpty()
        {
            if (algorithms == null) {
                algorithms = new Algorithm().GetAlgorithms();
            }

        }

        static public void SelectAlgorithm(string algorithmName)
        {
            SetAlgorithmsIfEmpty();

            AlgorithmObject result = algorithms.SingleOrDefault(
            algorithm => algorithm.name.ToLower() == algorithmName);

            if (result == null)
            {
                error();
                return;
            }

            result.instance.display();

        }

        static public void GenerateOptions()
        {

            SetAlgorithmsIfEmpty();

            options = "";

            foreach (var algorithm in algorithms)
            {
                options += algorithm.GetTextDescription() + "\n";
            }
        }

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
            Console.WriteLine("What program would you like to use? Available options:\n");
            Console.Write(options);
            Console.WriteLine("\nEnter 'menu' to display this menu again\n"
            + "Enter 'exit' to end the program...");
            Console.ResetColor();
        }

        public static void error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("You chose wrong option from the menu! (enter 'menu' to display menu again)");
            Console.ResetColor();
        }
        public static bool select(string choice)
        {
            string choiceLowered = choice.ToLower();

            switch (choiceLowered)
            {
                case "menu":
                    display();
                    break;
                case "exit":
                    return false;
                default:
                    SelectAlgorithm(choiceLowered);
                    break;
            }
            Console.WriteLine("\n");
            return true;
        }
    }
}
