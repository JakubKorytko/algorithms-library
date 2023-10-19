using System;
using System.Linq;
using System.Reflection;

namespace AlgorithmsLibrary.Algorithms
{

   /* internal class AlgorithmValidationResult
    {
        public bool TestPassed { get; private set; }
        public string AdditionalInfo { get; private set; }

    } */

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
        public virtual string Description { get { return "No description provided for this algorithm"; } }

        public bool intParseTest(string num)
        {

            bool isNumber = int.TryParse(num, out int n);

            if (isNumber == false)
            {
                Console.Write("You must enter a number!");
            }

            return isNumber;

        }

        public void PrintDescription()
        {
            Console.WriteLine(Description);
        }

        public virtual void display()
        {
            Console.WriteLine("No display method defined for this algorithm");
        }

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
            AlgorithmObject[] algorithms;

            algorithms = new AlgorithmObject[classes.Length];
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
