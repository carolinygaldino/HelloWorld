using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Britney";
            string lastName = "Spears";
            int age = 39;
            // Britney's last name is "Spears"
            Console.WriteLine(firstName + "\'s last name is\" " + lastName + " " + age);
        }
    }
}
