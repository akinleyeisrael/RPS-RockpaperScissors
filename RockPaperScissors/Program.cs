using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RockPaperScissors Game in C#");

            Random rand = new Random();
            int computer = rand.Next(1, 4);

            int play = 1;
            while (play == 1)
            {
                Console.WriteLine("Enter [1] for Rock, [2] for Paper, [3] for Scissors");
                int playerChoice = Int32.Parse(Console.ReadLine());

                if (playerChoice >= 1 && playerChoice <= 3)
                {
                    Console.WriteLine($"player: {playerChoice}");
                    Console.WriteLine($"computer: {computer}");

                    if (playerChoice != computer)
                    {
                        if (playerChoice == 1 && computer == 3 || playerChoice == 2 && computer == 1 || playerChoice == 3 && computer == 2)
                        {
                            Console.WriteLine("YOU WIN");
                        }
                        else if (computer == 1 && playerChoice == 3 || computer == 2 && playerChoice == 1 || computer == 3 && playerChoice == 2)
                        {
                            Console.WriteLine("COMPUTER WINS");
                        }
                    }
                    else
                    {
                        Console.WriteLine("TIE");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input,Pls enter values btw 1 and 3");
                }
            start:
                Console.WriteLine("Do you want to try again /n Enter yes or no");
                string userInput = Console.ReadLine();
                if (userInput == "yes")
                {
                    play = 1;
                }
                else if (userInput == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    goto start;
                }
            }

        }

    }
}

