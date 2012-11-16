using System.Collections.Generic;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    /// <summary>
    /// An interface that is used to construct the various methods/strategies for building a Poker hand.
    /// </summary>
    public interface IHandEvaluator
    {
        /// <summary>
        /// Determine if the cards provided can satisfy the requirements for a Poker hand.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s to evaluate.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s satsifies the requirements to build the hand; 
        /// otherwise <c>false</c>.</returns>
        bool HasHand(List<Card> cards);

        /// <summary>
        /// Determine the "score" or "weight" of a specified Poker hand.
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s to evaluate.</param>
        /// <returns>The value of the highest <c>Card</c> that satisfies the hand's requirement.</returns>
        /// <remarks>
        /// The value is only used as a tie-breaker in the event that two hands are of the same type.
        /// </remarks>
        int GetValue(List<Card> cards);
    }
}
