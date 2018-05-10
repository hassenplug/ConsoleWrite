using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCodeExample;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPass()
        {
            Assert.AreEqual(true, Output.Write("test screen", tOutputLocation.Screen));
            Assert.AreEqual(false, Output.Write("test db", tOutputLocation.Database));
            Assert.AreEqual(false, Output.Write("test file", tOutputLocation.TextFile));
        }
        [TestMethod]
        public void TestMethodFail()
        {
            // these will fail
            Assert.AreEqual(true, Output.Write("test db", tOutputLocation.Database));
            Assert.AreEqual(true, Output.Write("test file", tOutputLocation.TextFile));
        }
    }
}
