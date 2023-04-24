namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void printSomething(string fullName) //string firstName, string lastName
        {
            Console.WriteLine("The full name is " + fullName ); // firstName + " " + lastName
        }
        static void Main(string[] args)
        {
            printSomething("Chloe gallima"); //"Chloe", "Gallima"
        }
    }
}
