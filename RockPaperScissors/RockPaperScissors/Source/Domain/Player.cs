using RockPaperScissors.Source.Domain.Hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Domain
{
    public abstract class Player
    {
        protected abstract Ihand GetHand();

        internal Winner DeterminWinner(Player player)
        {
            if (GetHand().WinsFrom(player.GetHand()))
            {
                return new Winner(this);
            }

            return new Winner(player);    
        }
    }
}
