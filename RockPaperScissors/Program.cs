using System;

namespace RockPaperScissors
{
    internal static class Program
    {
        private static string ConvertToString(int choice)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "scissors";

            switch (choice)
            {
                case 1:
                    return rock;
                case 2:
                    return paper;
                default:
                    return scissors;
            }
        }

        private static void Print(int player, int computer)
        {
            if (player >= 1 && player <= 3)
            {
                Console.WriteLine($"Player:{ConvertToString(player)}");
                Console.WriteLine($"computer:{ConvertToString(computer)}");

                if (player != computer)
                {
                    if (player == 1 && computer == 3 || player == 2 && computer == 1 || player == 3 && computer == 2)
                    {
                        Console.WriteLine("YOU WIN");
                    }
                    else if (computer == 1 && player == 3 || computer == 2 && player == 1 || computer == 3 && player == 2)
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
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RockPaperScissors Game in C#");

            var rand = new Random();
            var computer = rand.Next(1, 4);

            var play = 1;
            while (play == 1)
            {
                Console.WriteLine("Enter [1] for Rock, [2] for Paper, [3] for Scissors");
                var player = int.Parse(Console.ReadLine());

                Print(player,computer);

            start:
                Console.WriteLine("Do you want to try again /n Enter yes or no");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "yes":
                        play = 1;
                        break;
                    case "no":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        goto start;
                }
            }
        }
    }
}