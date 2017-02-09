using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain.Hands
{
    class Scissor : Ihand
    {
        public Hand ToEnumValue()
        {
            return Hand.Scissor;
        }

        public bool WinsFrom(Ihand ihand)
        {
            return ihand is Paper;
        }

        public bool IsDraw(Ihand hand)
        {
            return hand is Scissor;
        }
    }
}
