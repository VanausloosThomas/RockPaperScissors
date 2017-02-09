using RockPaperScissors.Source.Domain.Hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Service
{
    class HandFactory
    {
        public Ihand ConvertHand(Hand hand)
        {
            if( hand == Hand.Paper)
            {
                return new Domain.Hands.Paper();
            }
            if(hand == Hand.Rock)
            {
                return new Rock();
            }
            return new Scissor();
        }
    }
}
