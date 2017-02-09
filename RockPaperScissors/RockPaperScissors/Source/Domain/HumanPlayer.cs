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
        private Ihand hand;

        public HumanPlayer(Ihand hand)
        {
            this.hand = hand;
        }

        protected override Ihand GetHand()
        {
            return hand;
        }
    }
}
