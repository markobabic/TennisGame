using System.Collections.Generic;

namespace TennisGame.Services.Model
{
    public class MatchResult
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public MatchResult(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
            Sets = new List<SetResult>();
        }
        public bool IsFinished { get; set; }
        public List<SetResult> Sets { get; set; }
        public Player Winner { get; set; }
    }
}
