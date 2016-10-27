using System;
using NUnit.Framework;
using Task06.Logic;

namespace Task06.NUnitTests
{
    [TestFixture]
    public class ExtensionToolsForStringTests
    {
        [TestCase("123","154",ExpectedResult = null)]
        [TestCase("", "", ExpectedResult = null)]
        [TestCase(" ", "   ", ExpectedResult = null)]
        [TestCase("\n", "\0", ExpectedResult = null)]
        [TestCase("asnkage.", "%nfk", ExpectedResult = null)]
        [TestCase("ABC", "DE", ExpectedResult = null)]
        [TestCase("a", "", ExpectedResult = null)]
        [TestCase("abcdefg", "abcdefg", ExpectedResult = "abcdefg")]
        [TestCase("abcdefg", "fghijk", ExpectedResult = "abcdefghijk")]
        [TestCase("aabbccddee", "eeffgghhiijjkk", ExpectedResult = "abcdefghijk")]
        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq",ExpectedResult = "abcdefklmopqwxy")]
        public string UnionAndSortLINQ_UnionOfTwoStrings(string fstStr,string scndStr)
        {
            return  ExtensionToolsForString.UnionAndSortLINQ(fstStr,scndStr);
        }
    }
}
