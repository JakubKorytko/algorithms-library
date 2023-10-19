using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.AlgorithmsCore
{
    internal class Algorithm: BaseClassTools
    {

        // Methods to override by derived classes
        public virtual string Description { get { return "No description provided for this algorithm"; } }

        public virtual void Display()
        {
            Console.WriteLine("No display method defined for this algorithm");
        }

    }
}
