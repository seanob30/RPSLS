using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }

        public override int MakeChoice()
        {
            do
            {
                base.MakeChoice();
                return choice;
            }
            while (!input.Equals("ROCK") && !input.Equals("PAPER") && !input.Equals("SCISSORS") && !input.Equals("LIZARD") && !input.Equals("SPOCK"));
        }
    }
}
