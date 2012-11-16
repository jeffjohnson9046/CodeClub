using System;
using CodeClub.ProjectEuler._54.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.ProjectEuler._54.UnitTests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void StraightFlush_Beats_OnePair()
        {
            #region Arrange

            var firstPlayerHand = new Hand(7, HandTypes.StraightFlush);
            var secondPlayerHand = new Hand(14, HandTypes.OnePair);
            int result = 0;

            #endregion


            #region Act

            result = firstPlayerHand.CompareTo(secondPlayerHand);

            #endregion


            #region Assert

            Assert.AreEqual(1, result);

            #endregion
        }

        [TestMethod]
        public void HighCard_Value_Ten_Beats_HighCard_Value_Nine()
        {
            #region Arrange

            var firstPlayerHand = new Hand(10, HandTypes.HighCard);
            var secondPlayerHand = new Hand(9, HandTypes.HighCard);
            int result = 0;

            #endregion


            #region Act

            result = firstPlayerHand.CompareTo(secondPlayerHand);

            #endregion


            #region Assert

            Assert.AreEqual(1, result);

            #endregion
        }
    }
}
