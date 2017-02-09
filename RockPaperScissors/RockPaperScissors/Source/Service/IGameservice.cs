using RockPaperScissors.Source.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Service
{
    interface IGameservice
    {
        MatchResult SinglePlayerGame(Hand hand);
    }
}
