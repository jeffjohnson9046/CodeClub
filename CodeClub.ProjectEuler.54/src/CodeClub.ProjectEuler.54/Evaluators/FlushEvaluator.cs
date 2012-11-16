using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    /// <summary>
    /// An implementation of <c>IHandEvaluator</c> that searches the collection of <c>Card</c>s for a Flush (i.e all 5 cards
    /// are the same suit, number on the card doesn't matter).
    /// </summary>
    public class FlushEvaluator : IHandEvaluator
    {
        /// <summary>
        /// Determine if the collection of <c>Card</c>s contains five <c>Card</c>s with the same <c>Suit</c>.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s contains five <c>Card</c>s with the same <c>Suit</c>; otherwise <c>false</c>.</returns>
        /// <remarks>
        /// The LINQ query groups all of the <c>Card</c>s by their <c>Suit</c>, looking for where the <c>Card.Suit</c>
        /// occurs five times.  If the <c>result</c> has one item, then there are five <c>Card</c>s with the same <c>Suit</c>.
        /// </remarks>
        public bool HasHand(List<Card> cards)
        {
            var result = cards.GroupBy(card => card.Suit)
                              .Where(g => g.Count() == 5);

            return result.Count() == 1;
        }

        /// <summary>
        /// Determine the <c>Value</c> of the <c>Hand</c>.  For a Flush, this is the highest card in the sequence.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns></returns>
        /// <remarks>
        /// Noah gave me the idea that only one card in the sequence of cards that satisfy the rules for the hand is enough to calculate the 
        /// <c>Hand</c>'s <c>Value</c>.  THANKS NOAH!
        /// </remarks>
        public int GetValue(List<Card> cards)
        {
            return cards.Max(card => card.Value);
        }
    }
}
