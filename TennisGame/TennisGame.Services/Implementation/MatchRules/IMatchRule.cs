using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation.MatchRules
{
    public interface IMatchRule
    {
        bool IsAchieved(MatchResult matchResult);
    }
}
