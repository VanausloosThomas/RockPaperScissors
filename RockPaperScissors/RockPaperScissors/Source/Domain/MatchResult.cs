using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain

{
    public class MatchResult
    {
        private Player winner, loser;
        public bool Draw { get; }

        public MatchResult(Player winner, Player loser)
        {
            this.winner = winner;
            this.loser = loser;
        }

        public MatchResult(Player winner, Player loser, bool draw) : this(winner, loser)
        {
            this.Draw = draw;
        }

        public string WinnerName()
        {
            return winner.Name();
        }

        public Hand WinnerHand()
        {
            return winner.hand.ToEnumValue();
        }

        public string LoserName()
        {
            return loser.Name();
        }

        public Hand LoserHand()
        {
            return loser.hand.ToEnumValue();
        }
    }
}