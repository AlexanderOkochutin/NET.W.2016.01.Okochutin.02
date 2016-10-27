using System;
using Task06.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task06.Tests
{
    [TestClass]
    public class ExtensionToolsForStringTests
    {
        [TestMethod]
        public void UnionAndSortLINQ_NumbersAndLetters_IncorrectInformationReturned()
        {
            string input1 = "15ga5adg6";
            string input2 = "";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1,input2);
            string expected = null;
            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void UnionAndSortLINQ_TwoEmptyStrings_IncorrectInformationReturned()
        {
            string input1 = "";
            string input2 = "";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1, input2);
            string expected = null;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void UnionAndSortLINQ_SpaceAndLettersStrings_IncorrectInformationReturned()
        {
            string input1 = "  ";
            string input2 = "asf";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1, input2);
            string expected = null;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void UnionAndSortLINQ_SpecialSymbolsAndLetters_IncorrectInformationReturned()
        {
            string input1 = "abgcv\0lsdg";
            string input2 = "asf";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1, input2);
            string expected = null;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void UnionAndSortLINQ_UpCaseLetters_IncorrectInformationReturned()
        {
            string input1 = "ABCDF";
            string input2 = "HIJK";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1, input2);
            string expected = null;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void UnionAndSortLINQ_TwoIdenticalStrings_SameStringReturned()
        {
            string input1 = "abcdefghijklmnop";
            string input2 = "abcdefghijklmnop";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1, input2);
            string expected = "abcdefghijklmnop";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void UnionAndSortLINQ_abcdfgANDhijklmn_abcdfghijklmnReturned()
        {
            string input1 = "abcdefg";
            string input2 = "hijklmn";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1, input2);
            string expected = "abcdefghijklmn";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void UnionAndSortLINQ_aabbccddANDccddffgg_abcdfgReturned()
        {
            string input1 = "aabbccdd";
            string input2 = "ccddffgg";
            string actual = ExtensionToolsForString.UnionAndSortLINQ(input1, input2);
            string expected = "abcdfg";
            Assert.AreEqual(actual, expected);
        }

    }
}
