using System;
using Xunit;
using Common;

namespace XUnitTestProject1
{
    public class ControllerCoreTests
    {
        [Fact]
        public void PutApiTest()
        {
			var putCall = new PutCall();
			Assert.Equal("hi", putCall.Test());
        }
    }
}
