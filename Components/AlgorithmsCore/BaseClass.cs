using System;

namespace AlgorithmsLibrary.AlgorithmsCore
{
    internal class Algorithm: BaseClassTools
    {
        public virtual string Description { get { return "No description provided for this algorithm"; } }

        public virtual void Display()
        {
            Console.WriteLine("No display method defined for this algorithm");
        }

    }
}
