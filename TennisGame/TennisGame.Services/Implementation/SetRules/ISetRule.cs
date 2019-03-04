using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation.SetRules
{
    public interface ISetRule
    {
        bool IsAchieved(SetResult result);
    }
}
