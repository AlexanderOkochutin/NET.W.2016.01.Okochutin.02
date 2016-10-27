using System;
using Task05.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task05.Tests
{
    [TestClass]
    public class ExtensionToolsForArrayTests
    {
        [TestMethod]
        public void IndexOfEquilibriumFinder_ShortArray_minus2Returned()
        {
            int[] arrayInput = {1, 2};
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = -2;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IndexOfEquilibriumFinder_ZeroArray_1Returned()
        {
            int[] arrayInput = {0, 0, 0, 0, 0, 0, 0};
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = 1;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void IndexOfEquilibriumFinder_12345678910Array_minus1Returned()
        {
            int[] arrayInput = {1,2,3,4,5,6,7,8,9,10};
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOfEquilibriumFinder_501112Array_1Returned()
        {
            int[] arrayInput = { 5,0,1,1,1,2 };
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOfEquilibriumFinder_1234010Array_4Returned()
        {
            int[] arrayInput = { 1,2,3,4,0,10 };
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOfEquilibriumFinder_12021Array_2Returned()
        {
            int[] arrayInput = { 1,2,0,2,1};
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOfEquilibriumFinder_AllNegative12021Array_2Returned()
        {
            int[] arrayInput = { -1, -2, 0, -2, -1 };
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOfEquilibriumFinder_PositiveAndNegative22011Array_2Returned()
        {
            int[] arrayInput = { 2,-2,0,1,-1};
            int actual = ExtensionToolsForArray.IndexOfEquilibriumFinder(arrayInput);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
