using System.Collections.Generic;
using TennisGame.Services.Model;

namespace TennisGame.Services
{
    public class TennisGameService : ITennisGameService
    {
        public MatchResult PlayMatch(Player player1, Player player2)
        {
            return new MatchResult(){IsFinished = true, Sets = new List<SetResult>{new SetResult(player1,player2){IsFinished = true}}};
        }
    }
}