namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void printSomething(string fullName)
        {
            Console.WriteLine("The full name is " + fullName );
        }
        static void Main(string[] args)
        {
            printSomething("Chloe gallima");
        }
    }
}
