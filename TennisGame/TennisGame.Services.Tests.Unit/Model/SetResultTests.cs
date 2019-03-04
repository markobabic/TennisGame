using TennisGame.Services.Model;
using Xunit;

namespace TennisGame.Services.Tests.Unit.Model
{
    public class SetResultTests
    {
        private Player _player1;
        private Player _player2;
        private readonly SetResult _setResult;

        public SetResultTests()
        {
            _player1 = new Player("player1");
            _player2 = new Player("player2");
            _setResult = new SetResult(_player1,_player2);
           
        }

        [Fact]
        public void When_Set_Is_Played_Then_Score_Is_Changed()
        {
            //act
            _setResult.Play();

            //Assert
            Assert.True(_setResult.Player1Score > 0 || _setResult.Player2Score > 0);

        }
    }
}
