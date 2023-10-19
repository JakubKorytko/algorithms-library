using System;
using System.Linq;
using System.Reflection;

namespace AlgorithmsLibrary.Algorithms
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

    internal class Algorithm
    {

        // Methods to override by derived classes
        public virtual string Description { get { return "No description provided for this algorithm"; } }

        public virtual void Display()
        {
            Console.WriteLine("No display method defined for this algorithm");
        }

        // Tools widely used in the derived classes

        public bool IntParseTest(string num)
        {

            bool isNumber = int.TryParse(num, out int _);

            if (!isNumber)
            {
                Console.Write("You must enter a number!");
            }

            return isNumber;

        }

        // Methods for retrieving derived classes

        private Type[] GetDerivedClasses()
        {
            // get array of derived classes
            Type[] DerivedClasses = AppDomain.CurrentDomain.GetAssemblies()
             .SelectMany(domainAssembly => domainAssembly.GetTypes())
             .Where(type => typeof(Algorithm).IsAssignableFrom(type) && type.Name != "Algorithm"
             ).ToArray();

            return DerivedClasses;
        }

        public AlgorithmObject[] GetAlgorithms() {

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
