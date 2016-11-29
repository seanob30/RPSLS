using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class CPU : Player
    {
        public CPU()
        {
            this.name = "CPU";
        }

        public override int MakeChoice()
        {
            Random cpuchoice = new Random();
            choice = cpuchoice.Next(0, 5);
            Console.Clear();
            return choice;
        }
    }
}
