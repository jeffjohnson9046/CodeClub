using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Evaluators
{
    /// <summary>
    /// An implementation of <c>IHandEvaluator</c> that searches the collection of <c>Card</c>s for a Full House (i.e Three of a Kind
    /// for one value, Two of a Kind for another).
    /// </summary>
    public class FullHouseEvaluator : IHandEvaluator
    {
        /// <summary>
        /// Determine if the collection of <c>Card</c>s contains a full house (i.e. one pair and three of a kind).
        /// </summary>
        /// <param name="cards">The collection of <c>Card</c>s being evaluated.</param>
        /// <returns><c>true</c> if the collection of <c>Card</c>s contains<c>Card</c>s that satisfy the <c>OnePairEvaluator</c> AND 
        /// the <c>ThreeOfAKindEvaluator</c>; 
        /// otherwise <c>false</c>.</returns>
        /// <remarks>
        /// The LINQ query groups all of the <c>Card</c>s by their <c>Value</c>, looking for where the <c>Card.Value</c>
        /// occurs three times.  If the <c>result</c> has one item, then use the <c>OnePairStategy</c> to see if the remaining two
        /// <c>Card.Value</c>s are a pair.
        /// </remarks>
        public bool HasHand(List<Card> cards)
        {
            var onePairStrategy = new OnePairEvaluator();
            var threeOfAKindStrategy = new ThreeOfAKindEvaluator();

            if (threeOfAKindStrategy.HasHand(cards))
            {
                // Find the cards that were used to build the three-of-a-kind part of the Full House.
                // These cards cannot be used when looking for the one pair part of the Full House.
                var cardsThatMakeThreeOfaKind = cards.GroupBy(card => card.Value)
                                                     .Where(g => g.Count() == 3)
                                                     .SelectMany(cardGroup => cardGroup);

                var remainingCards = cards.Except(cardsThatMakeThreeOfaKind).ToList();

                return onePairStrategy.HasHand(remainingCards);
            }

            return false;
        }

        /// <summary>
        /// Determine the <c>Value</c> of the <c>Hand</c>.  For a Full House, this is the value of one of the <c>Card</c>s that
        /// makes up the Three of a Kind.
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
                        .First(g => g.Count() == 3)
                        .Key;
        }
    }
}