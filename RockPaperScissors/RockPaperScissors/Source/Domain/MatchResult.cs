using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain

{
    public class MatchResult
    {
        private Player player1, otherPlayer, winner;
        public bool Draw { get; }

        public MatchResult(Player player1, Player otherPlayer,Player winner)
        {
            this.winner = winner;
            this.player1 = player1;
            this.otherPlayer = otherPlayer;
        }

        public MatchResult(Player player1, Player otherPlayer, bool draw) : this(player1, otherPlayer,null)
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

        public string Player1Name()
        {
            return player1.Name();
        }

        public Hand Player1Hand()
        {
            return player1.hand.ToEnumValue();
        }
        public string OtherPlayerName()
        {
            return otherPlayer.Name();
        }

        public Hand OtherPlayerHand()
        {
            return otherPlayer.hand.ToEnumValue();
        }
        public int Player1GetScore()
        {
            return player1.scoreCounter;
        }
        public int OtherPlayerGetScore()
        {
            return otherPlayer.scoreCounter;
        }
    }
}