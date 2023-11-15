using System;

// include this
using AlgorithmsLibrary.AlgorithmsCore;

namespace AlgorithmsLibrary.Algorithms
{

    // derive from the "Algorithm" class
    internal class SuperAlgorithm : Algorithm
    {
        // private field, you can add as many as you want
        private string exclamationMark;

        // override description to be displayed in the menu
        // (optional)
        public override string Description { get { return "I have the description!"; } }

        // private method, you can add as many as you want
        private string GetMessage(string text)
        {
            return "Im the algorithm! " +
                text +
                exclamationMark +
                " 1 + 1 = " +
                // method defined in the AlgorithmsCore/BaseClassTools.cs
                OnePlusOne();
        }

        // ovverride Display method to handle algorithm output
        // (optional, but required for functionality)
        public override void Display()
        {
            exclamationMark = "!";

            Console.Write(GetMessage("Hooray"));
        }
    }
}
