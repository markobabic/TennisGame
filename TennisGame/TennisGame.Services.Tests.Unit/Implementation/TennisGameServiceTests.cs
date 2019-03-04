using Moq;
using TennisGame.Services.Implementation;
using TennisGame.Services.Model;
using Xunit;

namespace TennisGame.Services.Tests.Unit.Implementation
{
    public class TennisGameServiceTests
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly TennisGameService _tennisGameService;
        private readonly Mock<IUmpireService> _umpireServiceMock;

        public TennisGameServiceTests()
        {
            _player1 = new Player("player1");
            _player2 = new Player("player2");
            _umpireServiceMock = new Mock<IUmpireService>();
            _tennisGameService = new TennisGameService(_umpireServiceMock.Object);
        }

        [Fact]
        public void Given_Two_Players_When_Match_Is_Played_Then_Match_Is_Finished()
        {
            //act
            var result = _tennisGameService.PlayMatch(_player1, _player2);

            //assert
            Assert.True(result.IsFinished);
        }

        [Fact]
        public void Given_Two_Players_When_Match_Is_Played_Then_SetResults_Are_Added()
        {
            //arrange
            _umpireServiceMock.Setup(us => us.ConductSet(_player1, _player2))
                .Returns(new SetResult(_player1, _player2) {IsFinished = true});

            //act
            var result = _tennisGameService.PlayMatch(_player1, _player2);

            //assert
            Assert.NotEmpty(result.Sets);
            Assert.All(result.Sets, r=> Assert.True(r.IsFinished));
        }
    }
}
