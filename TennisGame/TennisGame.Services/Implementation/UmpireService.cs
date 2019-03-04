using System.Collections.Generic;
using System.Linq;
using TennisGame.Services.Implementation.MatchRules;
using TennisGame.Services.Implementation.SetRules;
using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation
{
    public class UmpireService : IUmpireService
    {
        private readonly List<ISetRule> _setRules;
        private readonly List<IMatchRule> _matchRules;

        public UmpireService(List<ISetRule> setRules, List<IMatchRule> matchRules)
        {
            _setRules = setRules;
            _matchRules = matchRules;
        }
        public SetResult ConductSet(Player player1, Player player2)
        {
            var setResult  = new SetResult(player1,player2);

            while(!_setRules.All(r=> r.IsAchieved(setResult)))
                setResult.Play();

            setResult.IsFinished = true;

            setResult.Winner = setResult.Player2Score > setResult.Player1Score ? player2 : player1;

            return setResult;
        }

        public bool MatchIsOver(MatchResult matchResult)
        {
            return _matchRules.All(mr => mr.IsAchieved(matchResult));
        }
    }
}
