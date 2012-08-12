using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeClub.TowersOfHanoi.Core;

namespace CodeClub.TowersOfHanoi.UnitTests
{
    [TestClass]
    public class GameStateTests
    {
        [TestMethod]
        public void GameState_Equals_ReferenceEquals_Should_Return_True()
        {
            #region Arrange

            GameState state = new GameState();
            bool areEqual = false;

            #endregion

            #region Act

            areEqual = state.Equals(state);

            #endregion

            #region Assert

            Assert.IsTrue(areEqual);

            #endregion
        }

        [TestMethod]
        public void GameState_Equals_When_Towers_Are_The_Same_Should_Return_True()
        {
            #region Arrange

            GameState firstState = new GameState();
            firstState.Towers[0].AddDiskToTop(2);
            firstState.Towers[0].AddDiskToTop(1);
            firstState.Towers[1].AddDiskToTop(1);
            firstState.Towers[2].AddDiskToTop(5);

            GameState secondState = new GameState();
            secondState.Towers[0].AddDiskToTop(2);
            secondState.Towers[0].AddDiskToTop(1);
            secondState.Towers[1].AddDiskToTop(1);
            secondState.Towers[2].AddDiskToTop(5);

            bool areEqual = false;

            #endregion

            #region Act

            areEqual = firstState.Equals(secondState);

            #endregion

            #region Assert

            Assert.IsTrue(areEqual);

            #endregion
        }

        [TestMethod]
        public void GameState_Equals_When_Towers_Are_Different_Should_Return_False()
        {
            #region Arrange

            GameState firstState = new GameState();
            firstState.Towers[0].AddDiskToTop(2);
            firstState.Towers[0].AddDiskToTop(1);
            firstState.Towers[1].AddDiskToTop(1);
            firstState.Towers[2].AddDiskToTop(5);

            GameState secondState = new GameState();
            secondState.Towers[0].AddDiskToTop(4);
            secondState.Towers[0].AddDiskToTop(2);
            secondState.Towers[1].AddDiskToTop(6);
            secondState.Towers[2].AddDiskToTop(5);

            bool areEqual = true;

            #endregion

            #region Act

            areEqual = firstState.Equals(secondState);

            #endregion

            #region Assert

            Assert.IsFalse(areEqual);

            #endregion
        }
    }
}
