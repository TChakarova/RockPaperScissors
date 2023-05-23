using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Scissors = "Scissors";
            const string Paper = "Paper";
            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();
            if (playerMove == "rock" || playerMove == "r")
            {
                playerMove = Rock;
            }
            else if (playerMove == "scissors" || playerMove == "s")
            {
                playerMove = Scissors;
            }
            else if (playerMove == "paper" || playerMove == "p")
            {
                playerMove = Paper;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try again...");
                return;
            }
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove="";
            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock;
                    break;
                case 2:
                    computerMove = Paper;
                    break;
                case 3:
                    computerMove = Scissors;
                    break;
            }
            Console.WriteLine($"The computer chose {computerMove}.");
            if ((playerMove==Rock && computerMove==Scissors)|| (playerMove == Paper && computerMove == Rock)|| (playerMove == Scissors && computerMove == Paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == Rock && computerMove == Paper)|| (playerMove == Paper && computerMove == Scissors)|| (playerMove == Scissors && computerMove == Rock))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }
        }
    }
}
