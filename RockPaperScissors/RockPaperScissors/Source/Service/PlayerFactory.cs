using RockPaperScissors.Source.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Service
{
    class PlayerFactory
    {

        public HumanPlayer CreateNewHumanPlayer()
        {

            return new HumanPlayer();
        }

        internal ComputerPlayer CreateComputerPlayer()
        {
            var computerPlayer = new ComputerPlayer();
            computerPlayer.GenerateHand();
            return computerPlayer;
        }
    }
}
