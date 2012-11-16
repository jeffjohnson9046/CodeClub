using System.Collections.Generic;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;
using CodeClub.ProjectEuler._54.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.ProjectEuler._54.UnitTests
{
    [TestClass]
    public class GameLoaderTests
    {
        [TestMethod]
        public void Can_Build_GameRounds_From_Textfile()
        {
            #region Arrange

            List<Game> games = null;

            #endregion


            #region Act

            games = GamesLoader.LoadGames();

            #endregion


            #region Assert

            Assert.IsNotNull(games);
            Assert.AreEqual(1000, games.Count);

            #endregion
        }

        [TestMethod]
        public void Each_Round_Every_Player_Has_Five_Cards()
        {
            #region Arrange

            List<Game> games = null;

            #endregion


            #region Act 

            games = GamesLoader.LoadGames();

            #endregion


            #region Assert

            foreach (var game in games)
            {
                Assert.AreEqual(5, game.FirstPlayerCards.Count());
                Assert.AreEqual(5, game.SecondPlayerCards.Count());
            }

            #endregion
        }
    }
}
