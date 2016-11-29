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
        double result;
        string player;
        Player playerOne;
        Player playerTwo;
        public void RunGame()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WindowWidth = 50;
                this.round = 1;

                DisplayStartScreen();
                ChoosePlayers();
                EnterPlayerNames();
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
        private void DisplayStartScreen()
        {
            Console.WriteLine("    ***ROCK  PAPER  SCISSORS  LIZARD  SPOCK***");
            Console.WriteLine("           Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private void ChoosePlayers()
        {
            Console.Write("LOADING..");
            TakeShortBreak();
            Console.Clear();

            Console.Write("CHOOSE 1 OR 2 PLAYERS: ");
            player = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (player == "1" || player == "1 PLAYERS")
            {
                this.playerOne = new Human();
                this.playerTwo = new CPU();
            }
            else if (player == "2" || player == "2 PLAYERS")
            {

                this.playerOne = new Human();
                this.playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("NOT A VALID INPUT.. TRY AGAIN");
                TakeShortBreak();
                Console.Clear();
                ChoosePlayers();
            }
        }

        private void EnterPlayerNames()
        {
            if (player == "1" || player == "1 PLAYERS")
            {
                Console.Write("PLAYER NAME: ");
                playerOne.name = Console.ReadLine();
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
                EnterPlayerNames();
            }
        }

        private void PickWeapon()
        {
            Console.Write("LOADING...");
            TakeShortBreak();
            Console.Clear();

            Console.WriteLine("ROUND " + round++);
            TakeThreeSecondBreak();
            Console.Clear();

            playerOne.MakeChoice();
            playerTwo.MakeChoice();
        }

          

         private void DecideWinner()
        { 
                result = (5 + playerOne.choice - playerTwo.choice) % 5;

                if(result % 2 == 0)
                {
                    Console.WriteLine(playerTwo.name + " WINS!");
                    playerTwo.score++;
                    TakeThreeSecondBreak();
                    Console.Clear();
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine(playerOne.name + " WINS!");
                    playerOne.score++;
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

        private void CrownChampion()
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

        private void TakeThreeSecondBreak()
        {
            System.Threading.Thread.Sleep(3000);
        }

        private void TakeTenSecondBreak()
        {
            System.Threading.Thread.Sleep(10000);
        }

        private void TakeShortBreak()
        {
            System.Threading.Thread.Sleep(1000);
        }
    }

}