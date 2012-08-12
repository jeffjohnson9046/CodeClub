using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeClub.TowersOfHanoi.Core;

namespace CodeClub.TowersOfHanoi.UnitTests
{
    [TestClass]
    public class TowerTests
    {
        [TestMethod]
        public void Tower_Should_Add_Disks_To_Top_Of_Stack()
        {
            #region Arrange

            Tower tower = new Tower();
            int diskToAdd = 5;

            #endregion

            #region Act

            tower.AddDiskToTop(diskToAdd);

            #endregion

            #region Assert

            Assert.IsTrue(tower.Disks.First.Value == diskToAdd);

            #endregion
        }

        [TestMethod]
        public void Tower_Can_Add_Multipe_Disks_On_Top_Of_Each_Other()
        {
            #region Arrange

            Tower tower = new Tower();

            #endregion

            #region Act

            tower.AddDiskToTop(5);
            tower.AddDiskToTop(4);
            tower.AddDiskToTop(3);

            #endregion

            #region Assert

            Assert.AreEqual(3, tower.Disks.Count);

            #endregion
        }

        [TestMethod]
        public void Tower_Can_Get_Disk_From_Top_Of_Stack()
        {
            #region Arrange

            Tower tower = new Tower();
            int firstDisk = 5;
            int secondDisk = 4;
            int thirdDisk = 3;
            int fourthDisk = 2;

            int topDisk = 0;

            #endregion

            #region Act

            tower.AddDiskToTop(firstDisk);
            tower.AddDiskToTop(secondDisk);
            tower.AddDiskToTop(thirdDisk);
            tower.AddDiskToTop(fourthDisk);

            topDisk = tower.GetTopDisk();

            #endregion

            #region Assert

            Assert.AreEqual(fourthDisk, topDisk);

            #endregion
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Tower_Cannot_Add_A_Larger_Disk_On_Top_Of_A_Smaller_Disk()
        {
            #region Arrange

            Tower tower = new Tower();
            tower.AddDiskToTop(1);

            #endregion

            #region Act

            tower.AddDiskToTop(5);

            #endregion
        }

        [TestMethod]
        public void Tower_Get_Top_Disk_On_An_Empty_Stack_Of_Disks_Should_Return_Zero()
        {
            #region Arrange

            Tower tower = new Tower();
            int topDisk = -1;

            #endregion

            #region Act

            topDisk = tower.GetTopDisk();

            #endregion

            #region Assert

            Assert.AreEqual(0, topDisk);

            #endregion
        }

    }
}
