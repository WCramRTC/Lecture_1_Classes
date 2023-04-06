namespace Lecture_1_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new instance of our Bicycle class
            // What is an instance
            Bicycle bicycle = new Bicycle(-1);
            Bicycle bicycle2 = new Bicycle(-1)
            {
                // ctrl + space brings up intellisense
                Breaks = "Breaks",
                Pedals = "Pedals"
            };

        } // Main
    } // class

} // namespace