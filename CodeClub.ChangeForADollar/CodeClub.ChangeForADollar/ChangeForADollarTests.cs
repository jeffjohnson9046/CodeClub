using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeClub.ChangeForADollar
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        /// <summary>
        /// Verify that the <c>ChangeMaker</c> can count the correct number of combinations when the coin values are in
        /// descending order.  The collection of available coins includes a dollar coin (e.g. a Susan B. Anthony or Sacajawea).
        /// </summary>
        [TestMethod]
        public void CountChangeCombinations_Coins_In_Descending_Order_Including_A_Dollar_Coin()
        {
            #region Arrange

            int expectedCombinations = 293;
            int actualCombinations = 0;
            int[] coins = new[]{ 100, 50, 25, 10, 5, 1 };

            #endregion


            #region Act

            var changeMaker = new ChangeMaker(coins);
            actualCombinations = changeMaker.CountChangeCombinations(100, 5);

            #endregion


            #region Assert

            Assert.AreEqual(expectedCombinations, actualCombinations);

            #endregion
        }

        /// <summary>
        /// Verify that the <c>ChangeMaker</c> can count the correct number of combinations when the coin values are in
        /// descending order.  The collection of available coins excludes a dollar coin (e.g. a Susan B. Anthony or Sacajawea).
        /// </summary>
        [TestMethod]
        public void CountChangeCombinations_Coins_In_Descending_Order_Without_A_Dollar_Coin()
        {
            #region Arrange

            int expectedCombinations = 292;
            int actualCombinations = 0;
            int[] coins = new[] { 50, 25, 10, 5, 1 };

            #endregion


            #region Act

            var changeMaker = new ChangeMaker(coins);
            actualCombinations = changeMaker.CountChangeCombinations(100, 4);

            #endregion


            #region Assert

            Assert.AreEqual(expectedCombinations, actualCombinations);

            #endregion
        }

        /// <summary>
        /// Verify that the <c>ChangeMaker</c> can count the correct number of combinations when the coin values are in
        /// ascending order.  The collection of available coins includes a dollar coin (e.g. a Susan B. Anthony or Sacajawea).
        /// </summary>
        [TestMethod]
        public void CountChangeCombinations_Coins_In_Ascending_Order_Including_A_Dollar_Coin()
        {
            #region Arrange

            int expectedCombinations = 293;
            int actualCombinations = 0;
            int[] coins = new[] { 1, 5, 10, 25, 50, 100 };

            #endregion


            #region Act

            var changeMaker = new ChangeMaker(coins);
            actualCombinations = changeMaker.CountChangeCombinations(100, 5);

            #endregion


            #region Assert

            Assert.AreEqual(expectedCombinations, actualCombinations);

            #endregion            
        }

        /// <summary>
        /// Verify that the <c>ChangeMaker</c> can count the correct number of combinations when the coin values are in
        /// ascending order.  The collection of available coins excludes a dollar coin (e.g. a Susan B. Anthony or Sacajawea).
        /// </summary>
        [TestMethod]
        public void CountChangeCombinations_Coins_In_Ascending_Order_Without_A_Dollar_Coin()
        {
            #region Arrange

            int expectedCombinations = 292;
            int actualCombinations = 0;
            int[] coins = new[] { 1, 5, 10, 25, 50 };

            #endregion


            #region Act

            var changeMaker = new ChangeMaker(coins);
            actualCombinations = changeMaker.CountChangeCombinations(100, 4);

            #endregion


            #region Assert

            Assert.AreEqual(expectedCombinations, actualCombinations);

            #endregion
        }

        /// <summary>
        /// Verify that the <c>ChangeMaker</c> can count the correct number of combinations when the coin values are in
        /// a mixed order.  The collection of available coins includes a dollar coin (e.g. a Susan B. Anthony or Sacajawea).
        /// </summary>
        [TestMethod]
        public void CountChangeCombinations_Coins_In_Mixed_Order_Including_A_Dollar_Coin()
        {
            #region Arrange

            int expectedCombinations = 293;
            int actualCombinations = 0;
            int[] coins = new[] { 25, 1, 50, 10, 100, 5 };

            #endregion


            #region Act

            var changeMaker = new ChangeMaker(coins);
            actualCombinations = changeMaker.CountChangeCombinations(100, 5);

            #endregion


            #region Assert

            Assert.AreEqual(expectedCombinations, actualCombinations);

            #endregion
        }

        /// <summary>
        /// Verify that the <c>ChangeMaker</c> can count the correct number of combinations when the coin values are in
        /// mixed order.  The collection of available coins excludes a dollar coin (e.g. a Susan B. Anthony or Sacajawea).
        /// </summary>
        [TestMethod]
        public void CountChangeCombinations_Coins_In_Mixed_Order_Without_A_Dollar_Coin()
        {
            #region Arrange

            int expectedCombinations = 292;
            int actualCombinations = 0;
            int[] coins = new[] { 25, 1, 50, 10, 5 };

            #endregion


            #region Act

            var changeMaker = new ChangeMaker(coins);
            actualCombinations = changeMaker.CountChangeCombinations(100, 4);

            #endregion


            #region Assert

            Assert.AreEqual(expectedCombinations, actualCombinations);

            #endregion
        }
    }
}
