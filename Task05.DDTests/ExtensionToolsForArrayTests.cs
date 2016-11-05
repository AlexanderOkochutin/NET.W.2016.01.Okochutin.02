using System;
using System.Configuration;
using Task05.Logic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task05.DDTests
{
    [TestClass()]
    public class ExtensionToolsForArrayTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\ArraySamples.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task05.DDTests\\ArraySamples.xml")]
        [TestMethod]
        public void TestMethod()
        {
            int[] testData = Array.ConvertAll(Convert.ToString(TestContext.DataRow["value"]).Split(','), int.Parse);
            int rslt = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            Assert.AreEqual(rslt,testData.IndexOfEquilibriumFinder());
        }
    }
}
