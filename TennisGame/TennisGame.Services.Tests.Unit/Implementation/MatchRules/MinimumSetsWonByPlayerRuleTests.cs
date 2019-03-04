using System.Collections.Generic;
using TennisGame.Services.Implementation.MatchRules;
using TennisGame.Services.Model;
using Xunit;

namespace TennisGame.Services.Tests.Unit.Implementation.MatchRules
{
    
    public class MinimumSetsWonByPlayerRuleTests
    {
        [Fact]
        public void When_One_Set_Is_Played_Then_Game_Is_Not_Finished()
        {
            //arrange
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");
            var matchResult = new MatchResult(null, null)
            {
                Sets = new List<SetResult>
                {
                    new SetResult(player1,player2){Winner = player1}
                }
            };

            //act
            var result = new MinimumSetsWonByPlayerRule().IsAchieved(matchResult);

            //assert
            Assert.False(result);

        }

        [Fact]
        public void When_Each_Player_Won_One_Set_Then_Game_Is_Not_Finished()
        {
            //arrange
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");
            var matchResult = new MatchResult(null, null)
            {
                Sets = new List<SetResult>
                {
                    new SetResult(player1,player2){Winner = player1},
                    new SetResult(player1,player2){Winner = player2}
                }
            };

            //act
            var result = new MinimumSetsWonByPlayerRule().IsAchieved(matchResult);

            //assert
            Assert.False(result);

        }

        [Fact]
        public void When_Player_Won_Two_Sets_Then_Game_Is_Finished()
        {
            //arrange
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");
            var matchResult = new MatchResult(null, null)
            {
                Sets = new List<SetResult>
                {
                    new SetResult(player1,player2){Winner = player1},
                    new SetResult(player1,player2){Winner = player2},
                    new SetResult(player1,player2){Winner = player1}
                }
            };

            //act
            var result = new MinimumSetsWonByPlayerRule().IsAchieved(matchResult);

            //assert
            Assert.True(result);

        }

    }
}
