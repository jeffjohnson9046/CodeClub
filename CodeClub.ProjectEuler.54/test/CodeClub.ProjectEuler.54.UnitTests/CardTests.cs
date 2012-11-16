using System;
using System.Collections.Generic;
using CodeClub.ProjectEuler._54.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.ProjectEuler._54.UnitTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Can_Sort_Cards_in_a_Hand_in_Ascending_Order_By_Value()
        {
            #region "Arrange"

            var cards = new List<Card>
                {
                    new Card('7', 'C'),
                    new Card('2', 'C'),
                    new Card('5', 'H'),
                    new Card('3', 'S'),
                    new Card('4', 'C'),
                };

            #endregion


            #region "Act"

            cards.Sort();

            #endregion


            #region "Assert"
            
            Assert.AreEqual(2, cards[0].Value);
            Assert.AreEqual(3, cards[1].Value);
            Assert.AreEqual(4, cards[2].Value);
            Assert.AreEqual(5, cards[3].Value);
            Assert.AreEqual(7, cards[4].Value);

            #endregion
        }
    }
}
