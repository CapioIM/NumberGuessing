namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Introduction text
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Welcome to number guessing Game");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Computer has memorised random number between 1 and 100.");
                Console.WriteLine("Your objective is to guess number computer have chosen.");
                Console.WriteLine("In order to win game you will need to guess number within 5 attempts.");
                Console.WriteLine("Also computer will let you know number you entered is too high or too low.");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("\nLet's begin!");

                Random rng = new Random();
                int randomNumber = rng.Next(1, 101);    // random number between 1 and 100 generated and stored in variable
                int userGuess = 0;              // user input variable
                int triesLeft = 5;              // number of attempts
                const int CLOSE_BY_FIVE = 5;    // userGuess number is checked if is within this amount of numbers off against randomNumber

                for (int i = 0; i <= 5; i++)
                {
                    if (triesLeft > 0)
                    {
                        if (triesLeft < 5)
                        {
                            Console.WriteLine($"Tries left : {triesLeft}");
                        }
                        Console.WriteLine("What's your lucky guess ? ");
                        //read user text/convert to int
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
                    }
                    //Loss condition and loop breaks
                    if (triesLeft == 0)
                    {
                        Console.WriteLine("You lose");
                        Console.WriteLine("Oh no! You will be lucky next time !!!");
                        Console.WriteLine($"Computer had in mind number {randomNumber}.");
                        break;
                    }

                    // You're close if guess is 5 off
                    if (Math.Abs(randomNumber - userGuess) <= CLOSE_BY_FIVE)
                    {
                        Console.WriteLine($"Your guess is within {CLOSE_BY_FIVE} numbers off !");
                    }

                    triesLeft--;                                                 // Variable for number of tries deducted by 1
                }
                //start game again
                Console.WriteLine("Would you like to Try Again ? Y = Yes , any key is for no");
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
