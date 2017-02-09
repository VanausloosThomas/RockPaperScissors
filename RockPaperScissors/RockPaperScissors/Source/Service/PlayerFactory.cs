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
        private HandFactory handFactory = new HandFactory();

        public Player CreateNewHumanPlayer(Hand hand)
        {

            return new HumanPlayer(handFactory.ConvertHand(hand));
        }

        internal Player CreateComputerPlayer()
        {
            throw new NotImplementedException();
        }
    }
}
