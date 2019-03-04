using TennisGame.Services.Implementation.SetRules;
using TennisGame.Services.Model;
using Xunit;

namespace TennisGame.Services.Tests.Unit.Implementation.SetRules
{
    public class MinimumMarginRuleTests
    {

        [Theory]
        [InlineData(1, 2, false)]
        [InlineData(0, 6, true)]
        [InlineData(3, 7, true)]
        [InlineData(4, 3, false)]
        [InlineData(0, 0, false)]
        [InlineData(7, 8, false)]
        public void Achieved_Minimum_Margin_Set_Result(int player1Score, int player2Score, bool expectedResult)
        {
            //arrange
            var set = new SetResult(null, null) { Player1Score = player1Score, Player2Score = player2Score };

            //act
            var result = new MinimumMarginRule().IsAchieved(set);

            //assert
            Assert.Equal(expectedResult, result);

        }
    }
}
