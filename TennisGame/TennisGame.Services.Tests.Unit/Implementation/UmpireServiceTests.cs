using System.Collections.Generic;
using Moq;
using TennisGame.Services.Implementation;
using TennisGame.Services.Implementation.SetRules;
using TennisGame.Services.Model;
using Xunit;

namespace TennisGame.Services.Tests.Unit.Implementation
{
    public class UmpireServiceTests
    {
        private readonly UmpireService _umpireService;
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly Mock<ISetRule> _setRule;

        public UmpireServiceTests()
        {
            _player1 = new Player("player1");
            _player2 = new Player("player2");
            _setRule = new Mock<ISetRule>();
            _umpireService = new UmpireService(new List<ISetRule>{_setRule.Object});
        }

        [Fact]
        public void When_Set_Is_Conducted_Then_Set_Result_Is_Finished()
        {
            //arrange
            _setRule.Setup(sr => sr.IsAchieved(It.IsAny<SetResult>())).Returns(true);

            //act
            var result = _umpireService.ConductSet(_player1, _player2);

            //assert
            Assert.True(result.IsFinished);
        }

        [Fact]
        public void When_Set_Is_Conducted_Then_Set_Result_Has_Winner()
        {
            //arrange
            _setRule.Setup(sr => sr.IsAchieved(It.IsAny<SetResult>())).Returns(true);

            //act
            var result = _umpireService.ConductSet(_player1, _player2);

            //assert
            Assert.NotNull(result.Winner);
        }

        [Fact]
        public void Set_Is_Conducted_Untill_Rules_Are_Satisfied()
        {
            //arrange
            _setRule.SetupSequence(sr => sr.IsAchieved(It.IsAny<SetResult>())).Returns(false).Returns(false).Returns(true);

            //act
            var result = _umpireService.ConductSet(_player1, _player2);

            //assert
            Assert.Equal(3, result.Player1Score + result.Player2Score);
        }
    }
}
