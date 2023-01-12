class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        int magicNumberInt = randomGenerator.Next(1,101);

        Console.WriteLine("What is your guess? ");
        string userGuess = Console.ReadLine();
        
        int userGuessInt = Int32.Parse(userGuess);

        while (userGuessInt != magicNumberInt)
        {
            if (userGuessInt > magicNumberInt) 
            {
                Console.WriteLine("Lower");               
                Console.WriteLine("What is your guess? ");

                userGuess = Console.ReadLine();

                userGuessInt = Int32.Parse(userGuess);
            } else if (userGuessInt < magicNumberInt)
            { 
                Console.WriteLine("Higher");               
                Console.WriteLine("What is your guess? ");

                userGuess = Console.ReadLine();

                userGuessInt = Int32.Parse(userGuess);
            }
        }

        Console.WriteLine("You guessed it!");
    }
}