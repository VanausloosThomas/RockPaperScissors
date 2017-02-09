using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Source.Domain;

namespace RockPaperScissors.Source.Service
{
    class GameService : IGameservice
    {
        private PlayerFactory playerFactory = new PlayerFactory();

        public MatchResult SinglePlayerGame(Hand hand)
        {
            var humanPlayer = playerFactory.CreateNewHumanPlayer(hand);
            var computerPlayer = playerFactory.CreateComputerPlayer();

           return humanPlayer.DeterminWinner(computerPlayer);
           
        }
    }
}
