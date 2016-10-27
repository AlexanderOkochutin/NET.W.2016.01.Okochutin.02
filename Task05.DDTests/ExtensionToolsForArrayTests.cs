using System;
using System.Configuration;
using Task05.Logic;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task05.DDTests
{
    [TestClass()]
    public class ExtensionToolsForArrayTests
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\ArraySamples.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("DDT.Demo.Tests\\Users.xml")]
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
