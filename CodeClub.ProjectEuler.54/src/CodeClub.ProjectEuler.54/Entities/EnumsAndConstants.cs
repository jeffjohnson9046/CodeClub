namespace CodeClub.ProjectEuler._54.Entities
{
    /// <summary>
    /// Describes the position of the elements contained within a "card code".
    /// </summary>
    public class CardCodePositions
    {
        public const int VALUE = 0;
        public const int SUIT = 1;
    }

    /// <summary>
    /// Describes the possible hands that can be played.
    /// </summary>
    /// <remarks>
    /// Hands are enumerated in ascending order of value.
    /// </remarks>
    public enum HandTypes
    {
        HighCard,
        OnePair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush,
        RoyalFlush // TODO:  Necessary?  A RoyalFlush is just the highest possible Straight Flush...
    }

    /// <summary>
    /// Enumerates the players in a <c>Game</c>.
    /// </summary>
    public enum Players
    {
        One,
        Two
    }
}