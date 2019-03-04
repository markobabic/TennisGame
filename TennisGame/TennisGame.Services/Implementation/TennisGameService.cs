using System.Collections.Generic;
using TennisGame.Services.Model;

namespace TennisGame.Services.Implementation
{
    public class TennisGameService : ITennisGameService
    {
        private readonly IUmpireService _umpireService;

        public TennisGameService(IUmpireService umpireService)
        {
            _umpireService = umpireService;
        }


        public MatchResult PlayMatch(Player player1, Player player2)
        {
            var matchResult = new MatchResult(player1, player2);

           
            matchResult.Sets.Add(_umpireService.ConductSet(player1, player2));


            matchResult.IsFinished = true;

            return matchResult;
        }
    }
}