using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Domain.Hands
{
    class Scissor : Ihand
    {
        public bool WinsFrom(Ihand ihand)
        {
            return ihand is Paper;
        }
    }
}
