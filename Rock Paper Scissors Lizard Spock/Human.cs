using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Human : Player
    {

        public override int MakeChoice()
        {
            do
            {
                Console.Write(name + "'S CHOICE: ");
                input = Console.ReadLine().ToUpper();
                choice = Array.IndexOf(weaponsArray, input);
                Console.Clear();
                return choice;
            }
            while (!input.Equals("ROCK") && !input.Equals("PAPER") && !input.Equals("SCISSORS") && !input.Equals("LIZARD") && !input.Equals("SPOCK"));
        }
    }
}
