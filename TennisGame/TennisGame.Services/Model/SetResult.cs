using System;

namespace TennisGame.Services.Model
{
    public class SetResult
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public bool IsFinished { get; set; }

        public SetResult(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void Play()
        {
           _= new Random().Next(2) == 1 ? Player1Score++ : Player2Score++;
        }


    }
}