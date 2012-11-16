using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;
using CodeClub.ProjectEuler._54.Evaluators;

namespace CodeClub.ProjectEuler._54.Utilities
{
    /// <summary>
    /// A component that builds the best possible Poker hand out of a collection of <c>Card</c>s.
    /// </summary>
    public class HandBuilder
    {
        private readonly SortedList<HandTypes, IHandEvaluator> _strategies = new SortedList<HandTypes, IHandEvaluator>();
 
        public HandBuilder()
        {
            this.BuildStrategyCollection();
        }

        /// <summary>
        /// Build the best possible hand with the given collection of <c>Card</c>s.
        /// </summary>
        /// <param name="cards">A player's collection of <c>Card</c>s.</param>
        /// <returns>A <c>Hand</c> with a <c>HandType</c> describing the type of hand that was built and the <c>Hand</c>'s 
        /// <c>Value</c>, representing the "score" or "weight" of the <c>Hand</c>.
        /// </returns>
        public Hand GetHand(List<Card> cards)
        {
            Hand result = null;

            foreach (var strategyItem in _strategies.Reverse())
            {
                // If the collection of cards satisfies the current hand-building strategy, mark the hand with the
                // appropriate type and set the hand's value.
                if (strategyItem.Value.HasHand(cards))
                {
                    int handValue = strategyItem.Value.GetValue(cards);
                    result = new Hand(handValue, strategyItem.Key);
                    break;
                }
            }

            // If the hand doesn't sastifsy any of the strategies, then mark the hand as a HighCard hand, using
            // the highest single card as the hand's value.
            return result ?? new Hand(cards.Max(x => x.Value), HandTypes.HighCard);
        }

        /// <summary>
        /// Create a collection of <c>IHandEvaluator</c> objects, ranked highest to lowest.
        /// </summary>
        private void BuildStrategyCollection()
        {
            _strategies.Add(HandTypes.StraightFlush, new StraightFlushEvaluator());
            _strategies.Add(HandTypes.FourOfAKind, new FourOfAKindEvaluator());
            _strategies.Add(HandTypes.FullHouse, new FullHouseEvaluator());
            _strategies.Add(HandTypes.Flush, new FlushEvaluator());
            _strategies.Add(HandTypes.Straight, new StraightEvaluator());
            _strategies.Add(HandTypes.ThreeOfAKind, new ThreeOfAKindEvaluator());
            _strategies.Add(HandTypes.TwoPair, new TwoPairEvaluator());
            _strategies.Add(HandTypes.OnePair, new OnePairEvaluator());
        }
    }
}
