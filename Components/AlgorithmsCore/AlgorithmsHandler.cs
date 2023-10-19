using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Algorithms;
using AlgorithmsLibrary.AlgorithmsCore;

namespace AlgorithmsLibrary.AlgorithmsCore
{
    internal class AlgorithmsHandler
    {
        private Type[] GetDerivedClasses()
        {
            // get array of derived classes
            Type[] DerivedClasses = AppDomain.CurrentDomain.GetAssemblies()
             .SelectMany(domainAssembly => domainAssembly.GetTypes())
             .Where(type => typeof(Algorithm).IsAssignableFrom(type) && type.Name != "Algorithm"
             ).ToArray();

            return DerivedClasses;
        }

        public AlgorithmObject[] GetAlgorithms()
        {

            Type[] classes = GetDerivedClasses();
            AlgorithmObject[] algorithms = new AlgorithmObject[classes.Length];

            int i = 0;

            foreach (Type cls in classes)
            {

                AlgorithmObject algorithmData = new AlgorithmObject();

                Algorithm instance = (Algorithm)Activator.CreateInstance(cls);

                algorithmData.name = cls.Name;
                algorithmData.description = instance.Description;
                algorithmData.instance = instance;

                algorithms[i++] = algorithmData;

            }

            return algorithms;

        }
    }
}
