using System;
using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation.SetRules
{
    public class MinimumMarginRule : ISetRule
    {
        public bool IsAchieved(SetResult result)
        {
            return Math.Abs(result.Player2Score - result.Player1Score) > 1;
        }
    }
}
