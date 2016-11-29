using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Player
    {
        public string input;
        public int score = 0;
        public string name;
        public int choice;
        public string[] weaponsArray = { "ROCK", "PAPER", "SCISSORS", "SPOCK", "LIZARD" };

        public virtual int MakeChoice()
        {
            return choice;
        }
    }
}
