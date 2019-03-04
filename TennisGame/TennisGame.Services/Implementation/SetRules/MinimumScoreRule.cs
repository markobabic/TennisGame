using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation.SetRules
{
    public class MinimumScoreRule : ISetRule
    {
        private const int MinimumResult = 6;

        public bool IsAchieved(SetResult result)
        {
            return result.Player1Score >= MinimumResult || result.Player2Score >= MinimumResult;
        }
    }
}