using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeClub.TowersOfHanoi.Core.Recursive;

namespace CodeClub.TowersOfHanoi.UnitTests
{
    [TestClass]
    public class HanoiPuzzleTest
    {
        [TestMethod]
        public void HanoiPuzzle_Recursive_Solution_With_Four_Disks()
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
    }
}
