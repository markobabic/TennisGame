using System;
using System.Linq;
using TennisGame.Services;
using TennisGame.Services.Model;

namespace TennisGame
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = Services.IOC.Registrations.GetContainer())
            {
                var service = container.GetInstance<ITennisGameService>();

                var result = service.PlayMatch(new Player("Player 1"), new Player("Player 2"));

                Console.WriteLine($"Winner of the match is {result.Winner.Name}");


                Console.WriteLine($"Result of the match is {string.Join(",", result.Sets.Select(s=> $"{s.Player1Score} - {s.Player2Score}"))}");

            }

            Console.ReadKey();


        }
    }
}
