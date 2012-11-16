using System;

namespace CodeClub.ProjectEuler._54.Entities
{
    /// <summary>
    /// Represents a single playing card.
    /// </summary>
    public class Card : IComparable<Card>
    {
        public int Value { get; private set; }
        public char Suit { get; private set; }

        public Card(char value, char suit)
        {
            this.Value = ConvertCardValue(value);
            this.Suit = suit;
        }

        /// <summary>
        /// Convert the character value from the text file to a number.
        /// </summary>
        /// <param name="value">The single character value representing the card's value.</param>
        /// <returns>An <c>int</c> representing the card's value.</returns>
        private static int ConvertCardValue(char value)
        {
            switch (value)
            {
                case 'T':
                    return 10;
                case 'J':
                    return 11;
                case 'Q':
                    return 12;
                case 'K':
                    return 13;
                case 'A':
                    return 14;
                default:
                    return int.Parse(value.ToString());
            }
        }

        /// <summary>
        /// Handle sorting a collection of <c>Card</c>s by <c>Value</c> then by <c>Suit</c>.
        /// </summary>
        /// <param name="other">The <c>Card</c> to which this <c>Card</c> is being compared to.</param>
        /// <returns></returns>
        public int CompareTo(Card other)
        {
            if (null == other)
            {
                throw new ArgumentNullException("The other Card cannot be null.");
            }

            // If the Values of the cards are the same, compare the Suits.
            return this.Value == other.Value ? this.Suit.CompareTo(other.Suit) : this.Value.CompareTo(other.Value);
        }
    }
}
