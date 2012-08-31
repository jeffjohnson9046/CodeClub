
namespace CodeClub.ChangeForADollar
{
    public class ChangeMaker
    {
        /// <summary>
        /// An array of coin values.  Each element in the array should represent a valid U.S. currency value.
        /// </summary>
        /// <example>
        /// <code>
        /// this.AvailableCoins = { 1, 5, 10, 25, 50, 100 }
        /// </code>
        /// or
        /// <code>
        /// this.AvailableCoins = { 50, 25, 10, 5, 1 }
        /// </code>
        /// </example>
        public int[] AvailableCoins { get; private set; }

        /// <summary>
        /// Build a new <c>ChangeMaker</c> instance with the collection of available coins.
        /// </summary>
        /// <param name="availableCoins">The types of coins that are available for potential combinations.</param>
        public ChangeMaker(int[] availableCoins)
        {
            this.AvailableCoins = availableCoins;
        }

        /// <summary>
        /// Calculate the total number of combinations that can be used to make change for the specified amount using the
        /// available coins.
        /// </summary>
        /// <param name="totalAmount">The total amount (in cents).</param>
        /// <param name="coinIndex">The index of the current coin being used as part of the combination.</param>
        /// <returns>1 if the combination has created exact change; othrwise 0.</returns>
        public int CountChangeCombinations(int totalAmount, int coinIndex)
        {
            // When the totalAmount reaches 0, then we've made exact change, so return a match.
            if (totalAmount == 0)
            {
                return 1;
            }

            // If the total amount is less than 0 OR we've run out of coin types, then we haven't made a
            // valid combination so exit.
            // NOTE: As it turns out, I was wrong during CodeClub.  There *IS* a difference between totalAmount == 0
            // and totalAmount < 0.
            if (totalAmount < 0 || coinIndex < 0)
            {
                return 0;
            }

            // Calculate what's left to make change for.
            int remainingAmount = totalAmount - this.AvailableCoins[coinIndex];

            // Make change using the same coin against the remainingAmount (i.e. the "balance") AND the totalAmount using
            // the rest of the coins that are available.
            return this.CountChangeCombinations(remainingAmount, coinIndex) + this.CountChangeCombinations(totalAmount, --coinIndex);
        }
    }
}
