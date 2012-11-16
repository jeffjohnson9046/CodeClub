using System;
using CodeClub.ProjectEuler._54.Entities;
using CodeClub.ProjectEuler._54.Utilities;

namespace CodeClub.ProjectEuler._54
{
    public class PokerPlayer
    {
        public int Player1Wins { get; private set; }
        public int Player2Wins { get; private set; }

        public void PlayGames()
        {
            // Load the text file and build the hands for each player.
            var games = GamesLoader.LoadGames();

            // Play every round and increment the winner's win count.
            // TODO:  Lame.  This could probably be handled better and needs to be re-examined.
            foreach (var game in games)
            {
                Console.WriteLine("GAME {0}: ", games.IndexOf(game) + 1);

                var winner = game.Play();
                if (winner == Players.One)
                {
                    this.Player1Wins++;
                }
                else
                {
                    this.Player2Wins++;
                }
            }

            // Print output
            Console.WriteLine();
            Console.WriteLine("Player 1 Wins: {0}", this.Player1Wins);
            Console.WriteLine("Player 2 Wins: {0}", this.Player2Wins);
        }
    }
}
