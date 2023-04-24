namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new System.Random();
            int randomNumber = rand.Next(1, 100);
            int guess;
            bool continueGame = true;
            while(continueGame)
            {
                Console.WriteLine("Enter a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < randomNumber)
                {
                    Console.WriteLine("You've guessed low!");

                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("You've guessed high!");
                }
                else
                {
                    Console.WriteLine("You've guessed right!");
                    continueGame = false;
                }
            }

            
        }
    }
}
