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
