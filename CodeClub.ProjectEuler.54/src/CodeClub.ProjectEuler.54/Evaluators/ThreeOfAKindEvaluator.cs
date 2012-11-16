using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    /// <summary>
    /// An implementation of <c>IHandEvaluator</c> that searches the collection of <c>Card</c>s for a Three of a Kind (i.e. A <c>Card</c> 
    /// <c>Value</c> occurs three times in the collection of <c>Card</c>s).
    /// </summary>
    public class ThreeOfAKindEvaluator : IHandEvaluator
    {
        /// <summary>
        /// Determine if the collection of <c>Card</c>s contains three of a kind.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s contains three <c>Card</c>s with the same <c>Value</c>; 
        /// otherwise <c>false</c>.</returns>
        /// <remarks>
        /// The LINQ query groups all of the <c>Card</c>s by their <c>Value</c>, looking for where the <c>Card.Value</c>
        /// occurs three times.  If the <c>result</c> has one item, then three <c>Card</c>s with the same <c>Value</c> have been found.
        /// </remarks>
        public bool HasHand(List<Card> cards)
        {
            var result = cards.GroupBy(card => card.Value)
                              .Where(g => g.Count() == 3);

            return result.Count() == 1; ;
        }

        /// <summary>
        /// Determine the <c>Value</c> of the <c>Hand</c>.  For a Three of a Kind, this is one of the <c>Card</c> in
        /// the Three of a Kind.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns></returns>
        /// <remarks>
        /// Noah gave me the idea that only one card in the sequence of cards that satisfy the rules for the hand is enough to calculate the 
        /// <c>Hand</c>'s <c>Value</c>.  THANKS NOAH!
        /// </remarks>
        public int GetValue(List<Entities.Card> cards)
        {
            return cards.GroupBy(card => card.Value)
                        .First(g => g.Count() == 3)
                        .Key;
        }
    }
}
