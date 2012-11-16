using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.ProjectEuler._54.UnitTests
{
    [TestClass]
    public class PokerPlayerTests
    {
        /// <summary>
        /// There are 1000 two-player games of 5 card poker in the pokerHands.txt file.
        /// </summary>
        [TestMethod]
        public void Can_Play_All_Games()
        {
            #region Arrange

            var player = new PokerPlayer();

            #endregion


            #region Act

            player.PlayGames();

            #endregion


            #region Assert

            Assert.IsTrue(player.Player1Wins > 0);
            Assert.IsTrue(player.Player2Wins > 0);
            Assert.IsTrue(player.Player1Wins + player.Player2Wins == 1000);

            #endregion
        }
    }
}
