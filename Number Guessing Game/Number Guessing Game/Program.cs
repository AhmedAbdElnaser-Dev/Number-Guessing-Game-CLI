namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;

            Random random = new Random();
            int numberToGuess = random.Next(min, max + 1);

            int userGuess = 0;
            int chances = 5;

            Console.WriteLine("Welcome to the Number Guessing Game!");

            Console.WriteLine("Please select the difficulty level:");
            Console.WriteLine("1. Easy (10 chances)");
            Console.WriteLine("2. Medium (5 chances)");
            Console.WriteLine("3. Hard (3 chances)");
           
            Console.Write("\nEnter your choice (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());

            switch (difficulty)
            {
                case 1:
                    chances = 10;
                    Console.WriteLine("Great! You have selected the Easy difficulty level.");
                    break;

                case 2:
                    chances = 5;
                    Console.WriteLine("Great! You have selected the Medium difficulty level.");
                    break;


                case 3:
                    chances = 3;
                    Console.WriteLine("Great! You have selected the Easy difficulty level.");
                    break;
            }

            Console.WriteLine($"You have {chances} chances to guess the number between {min} and {max}.");

            for (int i = 0; i < chances; i++)
            {
                Console.Write($"\nEnter your guess ({i + 1}/{chances}): ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess < min || userGuess > max)
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                    i--; 
                    continue;
                }
                if (userGuess == numberToGuess)
                {
                    Console.WriteLine("Congratulations! You've guessed the number correctly!");
                    return;
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine($"Incorrect! The number is greater than {userGuess}.");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The number is less than {userGuess}.");
                }

                if (i == chances - 1)
                {
                    Console.WriteLine($"Sorry, you've used all your chances. The number was {numberToGuess}.");
                }
            }
        }
    }
}
