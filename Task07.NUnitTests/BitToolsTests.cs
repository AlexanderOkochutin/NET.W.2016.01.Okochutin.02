using System;
using Task07.Logic;
using NUnit.Framework;


namespace Task07.NUnitTests
{
    [TestFixture]
    public class BitToolsTests
    {
        [TestCase(0,0,5,1, ExpectedResult= null)]
        [TestCase(0,0,-1,1,ExpectedResult = null)]
        [TestCase(0,0,1,-1,ExpectedResult = null)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(15, -1, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 17)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        public int? BitInsertion_InsertionOfTwoInts(int fstInt,int scndInt,int startBit,int endBit)
        {
            return BitTools.BitInsertion(fstInt,scndInt,startBit,endBit);
        }
    }
}
