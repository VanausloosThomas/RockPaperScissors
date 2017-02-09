using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Domain.Hands
{
    class Paper : Ihand
    {
        public bool WinsFrom(Ihand ihand)
        {
            return ihand is Rock;
        }
    }
}
