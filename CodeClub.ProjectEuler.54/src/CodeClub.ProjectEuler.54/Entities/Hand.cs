using System;

namespace CodeClub.ProjectEuler._54.Entities
{
    /// <summary>
    /// Represents a poker hand and its associated value/weight.
    /// </summary>
    public class Hand : IComparable<Hand>
    {
        public int Value { get; private set; }
        public HandTypes Type { get; private set; }

        public Hand(int value, HandTypes type)
        {
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// Comparison logic to determine which hand is the winner.  If the <c>Hand</c>s have the same <c>HandType</c>, 
        /// the <c>Hand</c> with the <c>Value</c> is the winner.
        /// </summary>
        /// <param name="other">The <c>Hand</c> being compared against this one to determine which hand wins.</param>
        /// <returns>1 if this hand is the winner, otherwise -1.</returns>
        /// <remarks>
        /// <para>
        /// NOTE:  This comparison *does not* account for ties.  For example, if player 1 has 2C 2D 5S 7H 9S and player 2 has 
        /// 2H 2S 6C 8H 10S, player 2 *should* win (because player 2 has the highest kicker: 10S, which is higher than 
        /// player 1's highest side card: 9S).
        /// </para>
        /// <para>
        /// Omitting handling of the "kicker" card is okay for solivng this particular problem.  
        /// From the Project Euler Problem 54 page (http://projecteuler.net/problem=54):
        /// + You can assume that all hands are valid (no invalid characters or repeated cards)
        /// + each player's hand is in no specific order
        /// + in each hand there is a clear winner.
        /// </para>
        /// </remarks>
        public int CompareTo(Hand other)
        {
            if (null == other)
            {
                throw new ArgumentNullException("other hand cannot be null.");
            }

            // TODO:  Add handling for kicker/side card to determine winner.
            return this.Type.CompareTo(other.Type) == 0
                       ? this.Value.CompareTo(other.Value)
                       : this.Type.CompareTo(other.Type);
        }
    }
}
