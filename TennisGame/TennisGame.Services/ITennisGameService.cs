
using TennisGame.Services.Model;

namespace TennisGame.Services
{
    public interface ITennisGameService
    {
        MatchResult PlayMatch(Player player1, Player player2);
    }
}
