using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Game
    {
        int round;
        string player;
        double result;
        double firstChoice;
        double secondChoice;
        string[] weaponsArray = {"ROCK", "PAPER", "SCISSORS", "SPOCK", "LIZARD" };
        Player playerOne;
        Player playerTwo;
        public void RunGame()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WindowWidth = 50;

                this.playerOne = new Player();
                this.playerTwo = new Player();
                this.round = 1;

                StartScreen();
                ChoosePlayers();
                while (playerOne.score < 2 && playerTwo.score < 2)
                {
                    PickWeapon();
                    DecideWinner();
                }
                CrownChampion();

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    keepRunning = false;
                }
            }
            
        }
        public void StartScreen()
        {
            Console.WriteLine("    ***ROCK  PAPER  SCISSORS  LIZARD  SPOCK***");
            Console.WriteLine("           Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ChoosePlayers()
        {
            Console.Write("LOADING..");
            TakeShortBreak();
            Console.Clear();

            Console.Write("CHOOSE 1 OR 2 PLAYERS: ");
            player = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (player == "1" || player == "1 PLAYERS")
            {
                Console.Write("PLAYER NAME: ");
                playerOne.name = Console.ReadLine();
                playerTwo = new CPU();
                Console.Clear();
            }
            else if (player == "2" || player == "2 PLAYERS")
            {
                Console.Write("PLAYER 1 NAME: ");
                playerOne.name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("PLAYER 2 NAME: ");
                playerTwo.name = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("NOT A VALID INPUT.. TRY AGAIN");
                TakeShortBreak();
                Console.Clear();
                ChoosePlayers();
            }
        }

        public void PickWeapon()
        {
                Console.Write("LOADING...");
                TakeShortBreak();
                Console.Clear();

                Console.WriteLine("ROUND " + round++);
                TakeThreeSecondBreak();
                Console.Clear();
            if (player == "1" || player == "1 PLAYER")
            {
                do
                {
                    Console.Write(playerOne.name + "'S CHOICE: ");
                    playerOne.input = Console.ReadLine().ToUpper();
                    firstChoice = Array.IndexOf(weaponsArray, playerOne.input);
                    Console.Clear();
                }
                while (!playerOne.input.Equals("ROCK") && !playerOne.input.Equals("PAPER") && !playerOne.input.Equals("SCISSORS") && !playerOne.input.Equals("LIZARD") && !playerOne.input.Equals("SPOCK"));

                    Console.WriteLine(playerTwo.name + "'S CHOICE: " + secondChoice);
                    Random cpuchoice = new Random();
                    secondChoice = cpuchoice.Next(0, 5);
                    Console.Clear();
            }

            else if (player == "2" || player == "2 PLAYERS")
            {
                do
                {
                    Console.Write(playerOne.name + "'S CHOICE: ");
                    playerOne.input = Console.ReadLine().ToUpper();
                    firstChoice = Array.IndexOf(weaponsArray, playerOne.input);
                    Console.Clear();
                }
                while (!playerOne.input.Equals("ROCK") && !playerOne.input.Equals("PAPER") && !playerOne.input.Equals("SCISSORS") && !playerOne.input.Equals("LIZARD") && !playerOne.input.Equals("SPOCK"));

                do
                {
                    Console.Write(playerTwo.name + "'S CHOICE: ");
                    playerTwo.input = Console.ReadLine().ToUpper();
                    secondChoice = Array.IndexOf(weaponsArray, playerTwo.input);
                    Console.Clear();
                }
                while (!playerTwo.input.Equals("ROCK") && !playerTwo.input.Equals("PAPER") && !playerTwo.input.Equals("SCISSORS") && !playerTwo.input.Equals("LIZARD") && !playerTwo.input.Equals("SPOCK"));
            }
        }

        public void DecideWinner()
        { 
                result = (5 + firstChoice - secondChoice) % 5;

                if(result == 1 || result == 3)
                {
                    Console.WriteLine(playerOne.name + " WINS!");
                    playerOne.score++;
                    TakeThreeSecondBreak();
                    Console.Clear();
                }
                else if (result == 2 || result == 4)
                {
                    Console.WriteLine(playerTwo.name + " WINS!");
                    playerTwo.score++;
                    TakeThreeSecondBreak();
                    Console.Clear();
                }
                else if (result == 0)
                {
                    Console.WriteLine("STALEMATE..");
                    TakeThreeSecondBreak();
                    Console.Clear();
                }
            }

        public void CrownChampion()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " IS CHAMPION!!");
                Console.WriteLine();
                Console.WriteLine(playerOne.score + "-" + playerTwo.score + " WAS THE FINAL SCORE.");
                Console.WriteLine();
                Console.WriteLine("PRESS ESC TO EXIT");
                Console.WriteLine("OR");
                Console.WriteLine("WAIT 10 SECONDS TO PLAY AGAIN..THE CHOICE IS YOURS.");
                TakeTenSecondBreak();
                Console.Clear();
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine(playerTwo.name + " IS CHAMPION!!");
                Console.WriteLine();
                Console.WriteLine(playerTwo.score + "-" + playerOne.score + " WAS THE FINAL SCORE.");
                Console.WriteLine();
                Console.WriteLine("PRESS ESC TO EXIT");
                Console.WriteLine("OR");
                Console.WriteLine("WAIT 10 SECONDS TO PLAY AGAIN..THE CHOICE IS YOURS.");
                TakeTenSecondBreak();
                Console.Clear();
            }

        }

        public void TakeThreeSecondBreak()
        {
            System.Threading.Thread.Sleep(3000);
        }

        public void TakeTenSecondBreak()
        {
            System.Threading.Thread.Sleep(10000);
        }

        public void TakeShortBreak()
        {
            System.Threading.Thread.Sleep(1000);
        }
    }

}
