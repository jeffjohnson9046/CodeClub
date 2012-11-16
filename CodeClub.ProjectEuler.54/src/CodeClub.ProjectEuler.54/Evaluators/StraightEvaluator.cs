using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    /// <summary>
    /// An implementation of <c>IHandEvaluator</c> that searches the collection of <c>Card</c>s for a Straight (i.e. card 
    /// values are in sequence, the card's suit doesn't matter).
    /// </summary>
    public class StraightEvaluator : IHandEvaluator
    {
        /// <summary>
        /// Determine if the collection of <c>Card</c>s contains a Straight (i.e. <c>Card</c> <c>Value</c>s are in sequence).
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s contains<c>Card</c>s that satisfy the <c>StraightEvaluator</c>; 
        /// otherwise <c>false</c>.</returns>
        public bool HasHand(List<Card> cards)
        {
            var lowestValue = cards.Min().Value;
            var result = Enumerable.Range(lowestValue, cards.Count)
                                   .Except(cards.Select(x => x.Value));

            return !result.Any();
        }

        /// <summary>
        /// Determine the <c>Value</c> of the <c>Hand</c>.  For a Straight, this is the highest value of the <c>Card</c> in
        /// the seqence.
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
