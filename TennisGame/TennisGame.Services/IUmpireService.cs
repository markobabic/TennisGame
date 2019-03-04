using TennisGame.Services.Model;

namespace TennisGame.Services
{
    public interface IUmpireService
    {
        SetResult ConductSet(Player player1, Player player2);
    }
}
