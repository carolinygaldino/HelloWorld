
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageOfViewer = 19;
            if (ageOfViewer < 15)
            {
                System.Console.WriteLine("U, PG & 12 films are available.");
            }

            else if (ageOfViewer < 18)
            {
                System.Console.WriteLine("U, PG, 12 & 15 films are available.");
            }

            else
            {
                System.Console.WriteLine("All films are available");
            }
        }
    }
}
