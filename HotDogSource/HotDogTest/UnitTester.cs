using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotDogDAO;

namespace HotDogTest
{
    [TestClass]
    public class UnitTester
    {
        // Variables.
        MenuItem testItem;

        // Initializer.
        [TestInitialize]
        public void TestInitialize()
        {
            testItem = new MenuItem("Sun Chips", 0.99);
        }

        // Intentional fail test.
        [TestMethod]
        public void TestFail()
        {
            // Act.
            String tempCat = testItem.ItemCat;

            // Assert.
            Assert.AreEqual("", tempCat);
        }

        // Intentional pass test.
        [TestMethod]
        public void TestPass()
        {
            // Act.
            String tempCat = testItem.ItemCat;

            // Assert.
            Assert.AreEqual(null, tempCat);
        }

        // Cleanup.
        [TestCleanup]
        public void TestCleanup()
        {
            testItem = null;
        }
    }
}