

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            // && means "logical and"
            // || meand "logical or"
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                System.Console.WriteLine("Good morning!");
            }

            else if (timeOfDay >= 12 && timeOfDay <= 18)
            {
                System.Console.WriteLine("Good afternoon!");
            }

            else
            {
                System.Console.WriteLine("Good evening!");
            }
        }
    }
}
