using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CodeClub.TowersOfHanoi.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.TowersOfHanoi.UnitTests
{
    [TestClass]
    public class HanoiPuzzleTest
    {
        [TestMethod]
        public void Recursive_Solution_With_Four_Disks()
        {
            #region Arrange

            var puzzle = new HanoiPuzzle();

            #endregion


            #region Act

            puzzle.Solve(4, "sourcePeg", "destinationPeg", "intermediatePeg");

            #endregion


            #region Assert

            #endregion
        }

        [TestMethod]
        public void Recursive_Solution_With_Seven_Disks()
        {
            #region Arrange

            var puzzle = new HanoiPuzzle();

            #endregion


            #region Act

            puzzle.Solve(7, "sourcePeg", "destinationPeg", "intermediatePeg");

            #endregion


            #region Assert

            #endregion
        }
    }
}
