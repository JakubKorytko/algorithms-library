using System;
using AlgorithmsLibrary.Algorithms;

namespace AlgorithmsLibrary
{
    internal class Program
    {

        static void Main(string[] args) {

            Menu.Run();

            bool status = true;

            while (status) status = Menu.select(Menu.input());
        }
    }
}