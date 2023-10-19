using System;
using System.Linq;
using System.Net.NetworkInformation;
using AlgorithmsLibrary.AlgorithmsCore;

namespace AlgorithmsLibrary
{
    internal static class Menu
    {

        private static AlgorithmObject[] algorithms;

        public static void RunLoop()
        {
            bool loop = true;

            SetAlgorithmsIfEmpty();
            ShowOptions();

            while (loop) loop = Select(Input());
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

        public static void PrintOptions()
        {

            SetAlgorithmsIfEmpty();

            foreach (var algorithm in algorithms)
            {
                PrintCommand(algorithm.name);

                Console.Write(" ");

                PrintDescription(algorithm.description);

                Console.WriteLine("");
            }

            Console.ResetColor();
        }

        public static string Input()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("select> ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string option = Console.ReadLine().Trim();
            Console.WriteLine();
            Console.ResetColor();

            return option;
        }

        private static void PrintCommand(string command)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(command);
            Console.ResetColor();
        }

        private static void PrintDescription(string description)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("(" + description + ")");
            Console.ResetColor();
        }

        public static void ShowOptions()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What program would you like to use?");
            Console.WriteLine("Available options (case-insensitive):\n");
            PrintOptions();

            Console.Write("\nEnter '");
            PrintCommand("menu");
            Console.Write("' to display this menu again\n");

            Console.Write("Enter '");
            PrintCommand("exit");
            Console.Write("' to end the program...\n\n");

            Console.ResetColor();
        }

        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("You chose wrong option from the menu! (enter '");
            PrintDescription("menu");
            Console.Write("' to display menu again)");
            Console.ResetColor();
        }
        public static bool Select(string choice)
        {
            string choiceLowered = choice.ToLower();

            switch (choiceLowered)
            {
                case "menu":
                    ShowOptions();
                    break;
                case "exit":
                    return false;
                default:
                    SelectAlgorithm(choiceLowered);
                    Console.WriteLine("\n");
                    break;
            }
            return true;
        }
    }
}
