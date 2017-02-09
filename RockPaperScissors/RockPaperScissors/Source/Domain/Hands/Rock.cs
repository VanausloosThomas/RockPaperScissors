using RockPaperScissors.Source.Domain.Hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain.Hands
{
    class Rock : Ihand
    {

        public Hand ToEnumValue()
        {
            return Hand.Rock;
        }

        public bool WinsFrom(Ihand ihand)
        {
            return ihand is Scissors;
        }

        public bool IsDraw(Ihand hand)
        {
            return hand is Rock;
        }

    }
}
