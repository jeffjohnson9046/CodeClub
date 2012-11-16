using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    /// <summary>
    /// An implementation of <c>IHandEvaluator</c> that searches the collection of <c>Card</c>s for a Straight Flush (i.e. <c>Card</c> 
    /// <c>Value</c>s are in sequence and all <c>Card</c>s are of the same <c>Suit</c>).
    /// </summary>
    public class StraightFlushEvaluator : IHandEvaluator
    {
        /// <summary>
        /// Determine if the collection of <c>Card</c>s contains a Straight Flush (i.e. <c>Card</c> <c>Value</c>s are in sequence and 
        /// all <c>Card</c>s are of the same <c>Suit</c>).
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s contains<c>Card</c>s that satisfy the <c>StraightEvaluator</c> AND 
        /// the <c>FlushEvaluator</c>; 
        /// otherwise <c>false</c>.</returns>
        public bool HasHand(List<Card> cards)
        {
            var flushStrategy = new FlushEvaluator();
            var straightStrategy = new StraightEvaluator();

            return flushStrategy.HasHand(cards) && straightStrategy.HasHand(cards);
        }

        /// <summary>
        /// Determine the <c>Value</c> of the <c>Hand</c>.  For a Straight Flush, this is the highest value of the <c>Card</c> in
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
