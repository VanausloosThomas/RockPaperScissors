using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain.Hands
{
    class Paper : Ihand
    {

        public Hand ToEnumValue()
        {
            return Hand.Paper;
        }

        public bool WinsFrom(Ihand ihand)
        {
            return ihand is Rock;
        }

        public bool IsDraw(Ihand hand)
        {
            return hand is Paper;
        }
    }
}
