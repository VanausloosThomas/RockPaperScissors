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
        private HandFactory handFactory = new HandFactory();
        private GameFactory gameFactory = new GameFactory();
        private IGame currentGame;

        public void InitialiseSinglePlayerGame()
        {
            currentGame = gameFactory.InitialiseSinglePlayerame();
        }

        public MatchResult PlayGame(Hand hand)
        {
            return currentGame.PlayGame(handFactory.ConvertHand(hand));
        }
    }
}
