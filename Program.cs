using System;
using AlgorithmsLibrary.Algorithms;

namespace AlgorithmsLibrary
{
    internal static class Program
    {

        static void Main() {

            Menu.Run();

            bool status = true;

            while (status) status = Menu.Select(Menu.Input());
        }
    }
}