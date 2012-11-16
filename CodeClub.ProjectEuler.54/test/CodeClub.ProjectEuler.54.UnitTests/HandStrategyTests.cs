using System;
using System.Collections.Generic;
using CodeClub.ProjectEuler._54.Entities;
using CodeClub.ProjectEuler._54.Evaluators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.ProjectEuler._54.UnitTests
{
    [TestClass]
    public class HandStrategyTests
    {
        // A completely dead hand.  Y'know, the kind of hand I get dealt all the time...
        private readonly List<Card> _worstHandEver = new List<Card>
            {
                new Card('2', 'C'),
                new Card('3', 'D'),
                new Card('4', 'H'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };

        #region HasHand Tests

        /// <summary>
        /// Hand has a pair of 7's.
        /// </summary>
        [TestMethod]
        public void OnePairStrategy_Can_Find_One_Pair_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('7', 'C'),
                new Card('2', 'D'),
                new Card('4', 'H'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };

            bool hasPair = false;
            var onePairStrategy = new OnePairEvaluator();

            #endregion


            #region Act

            hasPair = onePairStrategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(hasPair);

            #endregion
        }

        /// <summary>
        /// Hand has no pair.
        /// </summary>
        [TestMethod]
        public void OnePairStrategy_Does_Not_Have_One_Pair_in_a_Hand()
        {
            #region Arrange

            bool hasPair = true;
            var onePairStrategy = new OnePairEvaluator();

            #endregion


            #region Act

            hasPair = onePairStrategy.HasHand(_worstHandEver);

            #endregion


            #region Assert

            Assert.IsFalse(hasPair);

            #endregion
        }

        /// <summary>
        /// Hand has a pair of 7's and a pair of 5's.
        /// </summary>
        [TestMethod]
        public void TwoPairStrategy_Can_Find_Two_Pairs_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('7', 'C'),
                new Card('5', 'D'),
                new Card('4', 'H'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };

            bool hasPair = false;
            var strategy = new TwoPairEvaluator();

            #endregion


            #region Act

            hasPair = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(hasPair);

            #endregion
        }

        /// <summary>
        /// Hand has no pairs.
        /// </summary>
        [TestMethod]
        public void TwoPairStrategy_Has_No_Pair_in_a_Hand()
        {
            #region Arrange

            bool hasPair = true;
            var strategy = new TwoPairEvaluator();

            #endregion


            #region Act

            hasPair = strategy.HasHand(_worstHandEver);

            #endregion


            #region Assert

            Assert.IsFalse(hasPair);

            #endregion
        }

        /// <summary>
        /// Hand has a pair of 7's.  That isn't two pair, so the <c>TwoPairEvaluator</c> should return false.
        /// </summary>
        [TestMethod]
        public void TwoPairStrategy_Has_Only_One_Pair_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('7', 'C'),
                new Card('3', 'D'),
                new Card('4', 'H'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };
            bool hasTwoPair = true;
            var strategy = new TwoPairEvaluator();

            #endregion


            #region Act

            hasTwoPair = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsFalse(hasTwoPair);

            #endregion
        }

        /// <summary>
        /// Hand has a pair of 7's.  That isn't three of a kind, so the <c>TwoPairEvaluator</c> should return false.
        /// </summary>
        [TestMethod]
        public void ThreeOfAKindStrategy_Does_Not_Have_Three_of_a_Kind_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('7', 'C'),
                new Card('3', 'D'),
                new Card('4', 'H'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };
            bool has3OfAKind = true;
            var strategy = new ThreeOfAKindEvaluator();

            #endregion


            #region Act

            has3OfAKind = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsFalse(has3OfAKind);

            #endregion
        }

        /// <summary>
        /// Hand has three 6's.
        /// </summary>
        [TestMethod]
        public void ThreeOfAKindStrategy_Has_Three_of_a_Kind_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('6', 'C'),
                new Card('3', 'D'),
                new Card('4', 'H'),
                new Card('6', 'S'),
                new Card('6', 'C'),
            };
            bool has3OfAKind = false;
            var strategy = new ThreeOfAKindEvaluator();

            #endregion


            #region Act

            has3OfAKind = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(has3OfAKind);

            #endregion
        }

        /// <summary>
        /// Has a pair of 7's.  That isn't four of a kind, so the <c>FourOfAKindEvaluator</c> should return false.
        /// </summary>
        [TestMethod]
        public void FourOfAKindStrategy_Does_Not_Have_Four_of_a_Kind_in_a_Hand()
        {
            #region Arrange

            var cards= new List<Card>
            {
                new Card('7', 'C'),
                new Card('3', 'D'),
                new Card('4', 'H'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };

            bool fourOfAKind = true;
            var strategy = new FourOfAKindEvaluator();

            #endregion


            #region Act

            fourOfAKind = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsFalse(fourOfAKind);

            #endregion
        }

        /// <summary>
        /// Has four 4's.
        /// </summary>
        [TestMethod]
        public void FourOfAKindStrategy_Has_Four_of_a_Kind_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('4', 'C'),
                new Card('4', 'D'),
                new Card('4', 'H'),
                new Card('4', 'S'),
                new Card('7', 'C'),
            };
            bool fourOfAKind = false;
            var strategy = new FourOfAKindEvaluator();

            #endregion


            #region Act

            fourOfAKind = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(fourOfAKind);

            #endregion     
        }

        /// <summary>
        /// <c>_worstHandEver</c> does not have a flush, so <c>FlushEvaluator</c> should return false.
        /// </summary>
        [TestMethod]
        public void FlushStrategy_Does_Not_Have_a_Flush_in_a_Hand()
        {
            #region Arrange

            bool flush = true;
            var strategy = new FlushEvaluator();

            #endregion


            #region Act

            flush = strategy.HasHand(_worstHandEver);

            #endregion


            #region Assert

            Assert.IsFalse(flush);

            #endregion  
        }

        /// <summary>
        /// Has a flush with Spades.
        /// </summary>
        [TestMethod]
        public void FlushStrategy_Has_a_Flush_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('2', 'S'),
                new Card('3', 'S'),
                new Card('4', 'S'),
                new Card('5', 'S'),
                new Card('7', 'S'),
            };
            bool flush = false;
            var strategy = new FlushEvaluator();

            #endregion


            #region Act

            flush = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(flush);

            #endregion  
        }

        [TestMethod]
        public void FullHouseStrategy_Does_Not_Have_a_Full_House()
        {
            #region Arrange

            bool fullHouse = true;
            var strategy = new FullHouseEvaluator();

            #endregion


            #region Act

            fullHouse = strategy.HasHand(_worstHandEver);

            #endregion


            #region Assert

            Assert.IsFalse(fullHouse);

            #endregion
        }

        [TestMethod]
        public void FullHouseStrategy_Has_a_Full_House_in_a_Hand()
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
            bool fullHouse = false;
            var strategy = new FullHouseEvaluator();

            #endregion


            #region Act

            fullHouse = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(fullHouse);

            #endregion
        }

        [TestMethod]
        public void StraightStrategy_Does_Not_Have_a_Straight_in_a_Hand()
        {
            #region Arrange

            bool hasStraight = true;
            var strategy = new StraightEvaluator();

            #endregion


            #region Act

            hasStraight = strategy.HasHand(_worstHandEver);

            #endregion


            #region Assert

            Assert.IsFalse(hasStraight);

            #endregion
        }

        [TestMethod]
        public void StraightStrategy_Has_a_Straight_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('J', 'S'),
                new Card('T', 'H'),
                new Card('A', 'D'),
                new Card('K', 'S'),
                new Card('Q', 'C'),
            };

            bool straight = false;
            var strategy = new StraightEvaluator();

            #endregion


            #region Act

            straight = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(straight);

            #endregion
        }

        [TestMethod]
        public void StraightFlushStrategy_Does_Not_Have_a_Straight_Flush_in_a_Hand()
        {
            #region Arrange

            bool straightFlush = true;
            var strategy = new StraightFlushEvaluator();

            #endregion


            #region Act

            straightFlush = strategy.HasHand(_worstHandEver);

            #endregion


            #region Assert

            Assert.IsFalse(straightFlush);

            #endregion
        }

        [TestMethod]
        public void StraightFlushStrategy_Has_a_Straight_Flush_in_a_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('T', 'S'),
                new Card('J', 'S'),
                new Card('Q', 'S'),
                new Card('K', 'S'),
                new Card('A', 'S'),
            };

            bool straight = false;
            var strategy = new StraightFlushEvaluator();

            #endregion


            #region Act

            straight = strategy.HasHand(cards);

            #endregion


            #region Assert

            Assert.IsTrue(straight);

            #endregion
        }

        #endregion


        #region GetValue Tests

        [TestMethod]
        public void FlushStrategy_Can_Get_Correct_Value_For_Hand()
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
            int value = 0;
            var strategy = new FullHouseEvaluator();

            #endregion


            #region Act

            value = strategy.GetValue(cards);

            #endregion


            #region Assert

            Assert.AreEqual(10, value);

            #endregion
            
        }

        [TestMethod]
        public void TwoPairStrategy_Can_Get_Correct_Value_For_Hand()
        {
            #region Arrange

            var cards = new List<Card>
            {
                new Card('7', 'C'),
                new Card('5', 'D'),
                new Card('4', 'H'),
                new Card('5', 'S'),
                new Card('7', 'C'),
            };

            int value = 0;
            var strategy = new TwoPairEvaluator();

            #endregion


            #region Act

            value = strategy.GetValue(cards);

            #endregion


            #region Assert

            Assert.AreEqual(7, value);

            #endregion
        }

        #endregion
    }
}
