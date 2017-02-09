using RockPaperScissors.Source.Domain;
using RockPaperScissors.Source.Domain.Hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Source.Service
{
    interface IGame
    {

        MatchResult PlayGame(Ihand hand);

    }
}
