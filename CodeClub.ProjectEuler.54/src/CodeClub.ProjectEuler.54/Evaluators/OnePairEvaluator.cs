using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    /// <summary>
    /// An implementation of <c>IHandEvaluator</c> that searches the collection of <c>Card</c>s for One Pair 
    /// (i.e  Two of a Kind for one value).
    /// </summary>
    public class OnePairEvaluator : IHandEvaluator
    {
        /// <summary>
        /// Determine if the collection of <c>Card</c>s contain a single pair.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s contains a single pair; otherwise <c>false</c>.</returns>
        /// <remarks>
        /// The LINQ query groups all of the <c>Card</c>s by their <c>Value</c>, looking for where the <c>Card.Value</c>
        /// occurs twice.  If the <c>result</c> has one item, then two <c>Card</c>s with the same <c>Value</c> have been found.
        /// </remarks>
        public bool HasHand(List<Card> cards)
        {
            var result = cards.GroupBy(card => card.Value)
                              .Where(g => g.Count() == 2);

            return result.Count() == 1;
        }

        /// <summary>
        /// Determine the <c>Value</c> of the <c>Hand</c>.  For One Pair, this is the value of one of the <c>Card</c>s that
        /// makes up the Pair.
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
                        .First(g => g.Count() == 2)
                        .Key;
        }
    }
}
