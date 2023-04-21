namespace AlgorithmsLibrary
{
    internal class Program
    {

        static void Main(string[] args) {

            Menu.select("menu");

            bool status = true;

            while (status) status = Menu.select(Menu.input());
        }
    }
}