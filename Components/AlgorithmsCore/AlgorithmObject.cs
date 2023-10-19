using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Algorithms;

namespace AlgorithmsLibrary.AlgorithmsCore
{
    internal class AlgorithmObject
    {

        public string name;
        public string description;
        public Algorithm instance;

        public string GetTextDescription()
        {
            return name + " (" + description + ")";
        }

    }
}
