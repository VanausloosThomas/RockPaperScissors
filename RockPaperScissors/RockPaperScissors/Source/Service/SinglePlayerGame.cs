using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Source.Domain;
using RockPaperScissors.Source.Domain.Hands;

namespace RockPaperScissors.Source.Service
{
    class SinglePlayerGame : IGame
    {
        HumanPlayer humanPlayer;
        ComputerPlayer computerPlayer;

        public SinglePlayerGame(HumanPlayer humanPlayer, ComputerPlayer computerPlayer)
        {
            this.humanPlayer = humanPlayer;
            this.computerPlayer = computerPlayer;
        }

        public MatchResult PlayGame(Ihand hand)
        {
            humanPlayer.PassHand(hand);
            computerPlayer.GenerateHand();
            return humanPlayer.DeterminWinner(computerPlayer);
        }
    }
}
