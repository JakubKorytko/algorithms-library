using System;
using System.Linq;
using AlgorithmsLibrary.AlgorithmsCore;

namespace AlgorithmsLibrary
{
    internal static class Menu
    {

        private static AlgorithmObject[] algorithms;
        private static string options;

        public static void Run()
        {
            SetAlgorithmsIfEmpty();
            GenerateOptions();
            Select("menu");
        }

        private static void SetAlgorithmsIfEmpty()
        {
            if (algorithms == null) {
                algorithms = new AlgorithmsHandler().GetAlgorithms();
            }

        }

        public static void SelectAlgorithm(string algorithmName)
        {
            SetAlgorithmsIfEmpty();

            AlgorithmObject result = algorithms.SingleOrDefault(
            algorithm => algorithm.name.ToLower() == algorithmName);

            if (result == null)
            {
                Error();
                return;
            }

            result.instance.Display();

        }

        public static void GenerateOptions()
        {

            SetAlgorithmsIfEmpty();

            options = "";

            foreach (var algorithm in algorithms)
            {
                options += algorithm.GetTextDescription() + "\n";
            }
        }

        public static string Input()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("select> ");
            string option = Console.ReadLine().Trim();
            Console.WriteLine();
            Console.ResetColor();

            return option;
        }

        public static void Display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What program would you like to use? Available options:\n");
            Console.Write(options);
            Console.WriteLine("\nEnter 'menu' to display this menu again\n"
            + "Enter 'exit' to end the program...");
            Console.ResetColor();
        }

        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("You chose wrong option from the menu! (enter 'menu' to display menu again)");
            Console.ResetColor();
        }
        public static bool Select(string choice)
        {
            string choiceLowered = choice.ToLower();

            switch (choiceLowered)
            {
                case "menu":
                    Display();
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
