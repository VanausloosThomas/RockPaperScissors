using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain.Hands
{
    class Scissors : Ihand
    {
        public Hand ToEnumValue()
        {
            return Hand.Scissors;
        }

        public bool WinsFrom(Ihand ihand)
        {
            return ihand is Paper;
        }

        public bool IsDraw(Ihand hand)
        {
            return hand is Scissors;
        }
    }
}
