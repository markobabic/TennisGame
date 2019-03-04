using System.Linq;
using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation.MatchRules
{
    public class MinimumSetsWonByPlayerRule : IMatchRule
    {
        public bool IsAchieved(MatchResult matchResult)
        {
            return matchResult.Sets
                .GroupBy(s => s.Winner).Any(group => group.Count() == 2);
        }
    }
}
