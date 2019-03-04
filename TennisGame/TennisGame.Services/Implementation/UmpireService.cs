using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation
{
    public class UmpireService : IUmpireService
    {
        public SetResult ConductSet(Player player1, Player player2)
        {
            return new SetResult(player1,player2){IsFinished = true, Winner = player1};
        }
    }
}
