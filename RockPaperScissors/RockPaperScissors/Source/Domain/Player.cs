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
        public Ihand hand { get; protected set; }
        public int scoreCounter { get; private set; }

        public abstract string Name();

        internal MatchResult DeterminWinner(Player player)
        {
            if (hand.WinsFrom(player.hand))
            {
                this.AddWin();
                return new MatchResult(this, player, this);
            }
            if (hand.IsDraw(player.hand))
            {
                return new MatchResult(this, player, true);
            }
            player.AddWin();
            return new MatchResult(this, player, player);
        }

        private void AddWin()
        {
            this.scoreCounter ++;
        }
    }
}
