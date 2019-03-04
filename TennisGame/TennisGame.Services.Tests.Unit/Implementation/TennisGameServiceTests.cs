using TennisGame.Services.Model;
using Xunit;

namespace TennisGame.Services.Tests.Unit.Implementation
{
    public class TennisGameServiceTests
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly TennisGameService _tennisGameService;

        public TennisGameServiceTests()
        {
            _player1 = new Player("player1");
            _player2 = new Player("player2");
            _tennisGameService = new TennisGameService();
        }

        [Fact]
        public void Given_Two_Players_When_Match_Is_Played_Then_Match_Is_Finished()
        {
            //act
            var result = _tennisGameService.PlayMatch(_player1, _player2);

            //assert
            Assert.True(result.IsFinished);
        }
    }
}
