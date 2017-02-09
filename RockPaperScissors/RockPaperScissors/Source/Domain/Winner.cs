using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain

{
    public class Winner
    {
        private Player player;

        public Winner(Player player) {
            this.player = player;
        }

        public string Name()
        {
            return "computer";
        }

        public Hand GetHand() {
            return Hand.Paper;
        }
    }
}