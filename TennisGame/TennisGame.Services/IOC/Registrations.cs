using StructureMap;
using TennisGame.Services.Implementation;
using TennisGame.Services.Implementation.MatchRules;
using TennisGame.Services.Implementation.SetRules;

namespace TennisGame.Services.IOC
{
    public static class Registrations
    {
        public static Container GetContainer()
        {
            var container = new Container();

            container.Configure(c =>
            {
                c.For<ITennisGameService>().Use<TennisGameService>();
                c.For<IUmpireService>().Use<UmpireService>();

                //RULES
                c.For<ISetRule>().Use<MinimumMarginRule>();
                c.For<ISetRule>().Use<MinimumScoreRule>();

                c.For<IMatchRule>().Use<MinimumSetsWonByPlayerRule>();
            });



            return container;
        }
    }
}
