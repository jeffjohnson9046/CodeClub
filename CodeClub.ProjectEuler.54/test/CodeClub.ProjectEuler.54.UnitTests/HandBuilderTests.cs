using System.Collections.Generic;
using CodeClub.ProjectEuler._54.Entities;
using CodeClub.ProjectEuler._54.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.ProjectEuler._54.UnitTests
{
    [TestClass]
    public class HandBuilderTests
    {
        [TestMethod]
        public void Can_Build_a_Flush_Hand_With_Clubs_and_a_Value_of_Fourteen()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('4', 'C'),
                new Card('7', 'C'),
                new Card('6', 'C'),
                new Card('9', 'C'),
                new Card('A', 'C'),
            };

            Hand flushHand = null;

            #endregion


            #region Act

            flushHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(flushHand);
            Assert.AreEqual(14, flushHand.Value);
            Assert.AreEqual(HandTypes.Flush, flushHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_a_FourOfAKind_Hand_With_a_Value_of_Two()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('2', 'S'),
                new Card('2', 'H'),
                new Card('2', 'D'),
                new Card('5', 'S'),
                new Card('2', 'C'),
            };

            Hand fourOfAKindHand = null;

            #endregion


            #region Act

            fourOfAKindHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(fourOfAKindHand);
            Assert.AreEqual(2, fourOfAKindHand.Value);
            Assert.AreEqual(HandTypes.FourOfAKind, fourOfAKindHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_a_FullHouse_Hand_With_a_Value_of_Ten()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('T', 'S'),
                new Card('T', 'H'),
                new Card('T', 'D'),
                new Card('J', 'S'),
                new Card('J', 'C'),
            };
            
            Hand fullHouseHand = null;

            #endregion


            #region Act

            fullHouseHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(fullHouseHand);
            Assert.AreEqual(10, fullHouseHand.Value);
            Assert.AreEqual(HandTypes.FullHouse, fullHouseHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_a_OnePair_Hand_With_a_Value_of_13()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('2', 'S'),
                new Card('5', 'H'),
                new Card('8', 'D'),
                new Card('K', 'S'),
                new Card('K', 'C'),
            };

            Hand onePairHand = null;

            #endregion


            #region Act

            onePairHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(onePairHand);
            Assert.AreEqual(13, onePairHand.Value);
            Assert.AreEqual(HandTypes.OnePair, onePairHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_a_StraightFlush_Hand_With_a_Value_of_Seven()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('3', 'H'),
                new Card('4', 'H'),
                new Card('5', 'H'),
                new Card('6', 'H'),
                new Card('7', 'H'),
            };

            Hand straightFlushHand = null;

            #endregion


            #region Act

            straightFlushHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(straightFlushHand);
            Assert.AreEqual(7, straightFlushHand.Value);
            Assert.AreEqual(HandTypes.StraightFlush, straightFlushHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_a_Straight_Hand_With_a_Value_of_Nine()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('9', 'S'),
                new Card('8', 'H'),
                new Card('7', 'D'),
                new Card('6', 'S'),
                new Card('5', 'C'),
            };

            Hand straightHand = null;

            #endregion


            #region Act

            straightHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(straightHand);
            Assert.AreEqual(9, straightHand.Value);
            Assert.AreEqual(HandTypes.Straight, straightHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_a_ThreeOfAKind_Hand_With_a_Value_of_Six()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('6', 'S'),
                new Card('6', 'H'),
                new Card('6', 'D'),
                new Card('4', 'S'),
                new Card('8', 'C'),
            };

            Hand threeOfAKindHand = null;

            #endregion


            #region Act

            threeOfAKindHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(threeOfAKindHand);
            Assert.AreEqual(6, threeOfAKindHand.Value);
            Assert.AreEqual(HandTypes.ThreeOfAKind, threeOfAKindHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_A_TwoPair_Hand_With_a_Value_of_Seven()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('5', 'S'),
                new Card('5', 'H'),
                new Card('2', 'D'),
                new Card('7', 'S'),
                new Card('7', 'C'),
            };

            Hand twoPairHand = null;

            #endregion


            #region Act

            twoPairHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(twoPairHand);
            Assert.AreEqual(7, twoPairHand.Value);
            Assert.AreEqual(HandTypes.TwoPair, twoPairHand.Type);

            #endregion
        }

        [TestMethod]
        public void Can_Build_a_HighCard_Hand_With_a_Value_of_Seven()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('2', 'S'),
                new Card('3', 'H'),
                new Card('4', 'D'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };

            Hand highCardHand = null;

            #endregion


            #region Act

            highCardHand = new HandBuilder().GetHand(cards);

            #endregion


            #region Assert

            Assert.IsNotNull(highCardHand);
            Assert.AreEqual(7, highCardHand.Value);
            Assert.AreEqual(HandTypes.HighCard, highCardHand.Type);

            #endregion
        }
    }
}
