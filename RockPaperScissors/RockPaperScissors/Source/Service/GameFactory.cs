using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Service
{
    class GameFactory
    {
        private PlayerFactory playerFactory = new PlayerFactory();
        private HandFactory handFactory = new HandFactory();

        public IGame InitialiseSinglePlayerame()
        {
            return new SinglePlayerGame(playerFactory.CreateNewHumanPlayer(), playerFactory.CreateComputerPlayer());
        }

    }
    
}
