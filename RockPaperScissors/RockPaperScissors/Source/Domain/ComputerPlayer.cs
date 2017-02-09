using System;
using RockPaperScissors.Source.Domain;
using RockPaperScissors.Source.Domain.Hands;
using System.Collections.Generic;

namespace RockPaperScissors.Source.Domain
{
    internal class ComputerPlayer : Player
    {
        List<Ihand> hands = new List<Ihand>()
        {
            new Scissor(),
            new Rock(),
            new Domain.Hands.Paper()
        };

        public void GenerateHand()
        {
            hand = hands[new Random().Next(0, 3)];
        }

        public override string Name()
        {
            return "Computer";
        }
    }
}