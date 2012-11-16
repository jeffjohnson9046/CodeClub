using System;
using System.Collections.Generic;
using CodeClub.ProjectEuler._54.Utilities;

namespace CodeClub.ProjectEuler._54.Entities
{
    /// <summary>
    /// Represents a single game of 5 card Poker between two players.
    /// </summary>
    public class Game
    {
        public List<Card> FirstPlayerCards { get; private set; }
        public List<Card> SecondPlayerCards { get; private set; }
        private readonly HandBuilder _builder;

        public Game(List<Card> firstPlayerCards, List<Card> secondPlayerCards, HandBuilder builder)
        {
            this.FirstPlayerCards = firstPlayerCards;
            this.SecondPlayerCards = secondPlayerCards;
            _builder = builder;
        }

        /// <summary>
        /// Build the best hand for both players and determine the winner.
        /// </summary>
        /// <returns>A <c>Players</c> enumeration describing the winner.</returns>
        public Players Play()
        {
            // Build the best hand for each player this round.
            Hand player1BestHand = _builder.GetHand(this.FirstPlayerCards);
            Hand player2BestHand = _builder.GetHand(this.SecondPlayerCards);

            // DEBUG:
            Console.WriteLine("Player 1 Hand: {0}, Value: {1}", player1BestHand.Type, player1BestHand.Value);
            Console.WriteLine("Player 2 Hand: {0}, Value: {1}", player2BestHand.Type, player2BestHand.Value);
            Console.WriteLine("Winner: {0}", player1BestHand.CompareTo(player2BestHand) == 1 ? Players.One : Players.Two);
            Console.WriteLine();

            // Determine the winner.
            return player1BestHand.CompareTo(player2BestHand) == 1 ? Players.One : Players.Two;
        }
    }
}
