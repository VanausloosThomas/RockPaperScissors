using RockPaperScissors.Source.Domain.Hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Domain
{
    class HumanPlayer : Player
    {
        public HumanPlayer(Ihand hand)
        {
            base.hand = hand;
        }

        public override string Name()
        {
            return "Player 1";
        }
    }
}
