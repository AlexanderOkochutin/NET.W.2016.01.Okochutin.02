using System;
using System.Collections;
using  NUnit.Framework;
using static Task05.Logic.ExtensionToolsForArray;

namespace Task05.Logic.NUnitTests
{

    [TestFixture]
    public class ExtensionToolsForArrayTests
    {
        public static IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData(new int[] {0, 0, 0, 0, 0}).Returns(1);
                yield return new TestCaseData(new int[] {1, 2, 3}).Returns(-1);
                yield return new TestCaseData(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}).Returns(-1);
                yield return new TestCaseData(new int[] {1, 2, 3, 0, 3, 2, 1}).Returns(3);
                yield return new TestCaseData(new int[] {1, -2, -3, 0, -4}).Returns(3);
            }
        }

        [Test, TestCaseSource(nameof(TestData))]
        public int IndexOfEquilibriumFinder_withYield(int[] input)
        {
            return input.IndexOfEquilibriumFinder();
        }
    }
}
