namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rng = new Random();
                const int RANDOM_MIN_VALUE = 1;
                const int RANDOM_MAX_VALUE = 101;
                int randomNumber = rng.Next(RANDOM_MIN_VALUE, RANDOM_MAX_VALUE);    // random number between 1 and 100 generated and stored in variable
                int userGuess = 0;                                                  // user input variable
                const int USER_IS_CLOSE_TO_GUESS = 5;                               // userGuess number is checked if is within this amount of numbers off against randomNumber
                const int TRIES = 5;                                                // number of attempts allowed
                int triesLeft = TRIES;                                              // number of tries left

                // Introduction text
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Welcome to number guessing Game");
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Computer has memorised random number between {RANDOM_MIN_VALUE} and {RANDOM_MAX_VALUE - 1}.");
                Console.WriteLine("Your objective is to guess number computer have chosen.");
                Console.WriteLine($"In order to win game you will need to guess number within {TRIES} attempts.");
                Console.WriteLine("Also computer will let you know number you entered is too high or too low.");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("\nLet's begin!");


                for (int i = 0; i < TRIES; i++)
                {
 
                        if (i > 0)              //every guess write amount of tries left after 1st guess
                        {
                            Console.WriteLine($"Tries left : {triesLeft}");
                            triesLeft--;                                                 // Variable for number of tries deducted by 1
                        }

                        Console.WriteLine("What's your lucky guess ? ");
                        //convert user guess to int
                        userGuess = Convert.ToInt32(Console.ReadLine());

                        //comparison / Win condition , after for loop breaks
                        if (userGuess == randomNumber)
                        {
                            Console.WriteLine("You win!!!! You can have tasty bisquit now!");
                            Console.WriteLine($"You guessed lucky number {randomNumber} !!!");
                            break;
                        }
                        //guess too low
                        if (userGuess < randomNumber)
                        {
                            Console.WriteLine("Number you have entered is too low.");
                        }
                        //guess to high
                        if (userGuess > randomNumber)
                        {
                            Console.WriteLine("Number you entered is too high.");
                        }
                        // You're close if guess is 5 off
                        if (Math.Abs(randomNumber - userGuess) <= USER_IS_CLOSE_TO_GUESS)
                        {
                            Console.WriteLine($"You'r close!");
                        }
                    
                }
                    //  code runs when run out of tries , Loss condition and loop breaks
                    if (randomNumber != userGuess)
                    {
                        Console.WriteLine("You lose");
                        Console.WriteLine("Oh no! You will be lucky next time !!!");
                        Console.WriteLine($"Computer had in mind number {randomNumber}.");
                    }
                //start game again
                Console.WriteLine("Would you like to try again ? Y = Yes , any key is for No");
                string repeatGame = Console.ReadLine().ToLower();
                if (repeatGame == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    return;
                }

            }
        }
    }
}
