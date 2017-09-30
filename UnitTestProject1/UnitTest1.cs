using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
			PutCall putCall = new PutCall();
			Assert.AreEqual("hi", putCall.Test());
		}
    }
}
