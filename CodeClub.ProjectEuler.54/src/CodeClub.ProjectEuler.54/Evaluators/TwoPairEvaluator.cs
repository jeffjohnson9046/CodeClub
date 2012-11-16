using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    public class TwoPairEvaluator : IHandEvaluator
    {
        /// <summary>
        /// Determine if the collection of <c>Card</c>s contain two pairs.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s contains a single pair; otherwise <c>false</c>.</returns>
        /// <remarks>
        /// The LINQ query groups all of the <c>Card</c>s by their <c>Value</c>, looking for where the <c>Card.Value</c>
        /// occurs twice.  If the <c>result</c> has two items, then there are two sets of <c>Card</c>s with the same <c>Value</c>.
        /// </remarks>
        public bool HasHand(List<Card> cards)
        {
            var result = cards.GroupBy(card => card.Value)
                              .Where(g => g.Count() == 2);

            return result.Count() == 2;
        }

        /// <summary>
        /// Determine the <c>Value</c> of the <c>Hand</c>.  For Two Pair, this is one of the <c>Card</c> in
        /// the highest numbered Pair.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns></returns>
        /// <remarks>
        /// Noah gave me the idea that only one card in the sequence of cards that satisfy the rules for the hand is enough to calculate the 
        /// <c>Hand</c>'s <c>Value</c>.  THANKS NOAH!
        /// </remarks>
        public int GetValue(List<Card> cards)
        {
            return cards.GroupBy(card => card.Value)
                        .Where(g => g.Count() == 2)
                        .Max(k => k.Key);
        }
    }
}
