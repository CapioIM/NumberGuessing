using System;

namespace NumberGuessing
{
    internal class Program
    {
        public static Random rng = new Random();
        public const int RANDOM_NUMBER_MIN_VALUE = 1;                                             // random Min Value
        public const int RANDOM_NUMBER_MAX_VALUE = 101;                                           // random Max Value -1
        public const int USER_IS_CLOSE_TO_GUESS = 5;                                              // userGuess number is checked if is within this amount of numbers off against randomNumber
        public const int TRIES = 5;                                                               // number of attempts allowed

        static void Main(string[] args)
        {
            while (true)
            {
                int randomNumber = rng.Next(RANDOM_NUMBER_MIN_VALUE, RANDOM_NUMBER_MAX_VALUE);    // random number between Min value and (Max Value -1) generated and stored in variable
                int userGuess = 0;                                                                // user input variable
                                                                                                  // Introduction text
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Welcome to number guessing Game");
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Computer has memorised random number between {RANDOM_NUMBER_MIN_VALUE} and {RANDOM_NUMBER_MAX_VALUE - 1}.");
                Console.WriteLine("Your objective is to guess number computer have chosen.");
                Console.WriteLine($"In order to win game you will need to guess number within {TRIES} attempts.");
                Console.WriteLine("Also computer will let you know number you entered is too high or too low.");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Let's begin!");

                for (int i = 0; i < TRIES; i++)
                {

                    if (i > 0)                                                                             //every guess write amount of tries left after 1st guess
                    {
                        Console.WriteLine($"Attempts left : {TRIES - i}");
                    }

                    Console.WriteLine("What's your lucky guess ? ");
                    userGuess = Convert.ToInt32(Console.ReadLine());                                       //convert user guess to int

                    if (userGuess == randomNumber)                                                         //comparison / Win condition , after for loop breaks
                    {
                        Console.WriteLine("You win!!!! You can have tasty bisquit now!");
                        Console.WriteLine($"You guessed lucky number {randomNumber} !!!");
                        break;
                    }

                    if (userGuess < randomNumber)
                    {
                        Console.WriteLine("Number you have entered is too low.");                           //guess too low
                    }

                    if (userGuess > randomNumber)                                                           //guess to high
                    {
                        Console.WriteLine("Number you entered is too high.");
                    }

                    if (Math.Abs(randomNumber - userGuess) <= USER_IS_CLOSE_TO_GUESS)             // You're close if guess is 5 off
                    {
                        Console.WriteLine($"You'r close!");
                    }

                }

                if (randomNumber != userGuess)                                                              // Loss condition 
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
                    break;
                }

            }
        }
    }

}
