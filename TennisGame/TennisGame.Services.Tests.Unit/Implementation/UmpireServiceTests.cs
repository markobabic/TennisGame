using TennisGame.Services.Implementation;
using TennisGame.Services.Model;
using Xunit;

namespace TennisGame.Services.Tests.Unit.Implementation
{
    public class UmpireServiceTests
    {
        private UmpireService _umpireService;
        private Player _player1;
        private Player _player2;

        public UmpireServiceTests()
        {
            _player1 = new Player("player1");
            _player2 = new Player("player2");
        }

        [Fact]
        public void When_Set_Is_Conducted_Then_Set_Result_Is_Finished()
        {
            //arrange
            _umpireService = new UmpireService();

            //act
            var result = _umpireService.ConductSet(_player1, _player2);

            //assert
            Assert.True(result.IsFinished);
        }

        [Fact]
        public void When_Set_Is_Conducted_Then_Set_Result_Has_Winner()
        {
            //arrange
            _umpireService = new UmpireService();

            //act
            var result = _umpireService.ConductSet(_player1, _player2);

            //assert
            Assert.NotNull(result.Winner);
        }
    }
}
