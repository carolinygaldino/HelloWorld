
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopControl = true; 
            //false
            while (loopControl == true)
            //(loopControl) for false
            {
                System.Console.WriteLine("We're in the loop!");
            }
        }
    }
}
