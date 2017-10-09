using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void P0Test()
        {
			PutCall putCall = new PutCall();
			string exampleJson = "{\"name\":\"Intel\",\"swaggerSpecURI\":\"foo\"}";
			 Assert.AreEqual(exampleJson, putCall.PutHelper());
		}

		[TestMethod]
		public void AzureCredTest()
		{
			PutCall putCall = new PutCall();
			Assert.IsNotNull(putCall.InitilizeAzureCred().Result);
		}
	}
}
