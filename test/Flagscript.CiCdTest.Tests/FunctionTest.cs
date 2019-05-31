using Amazon.Lambda.TestUtilities;
using Xunit;

namespace Flagscript.CiCdTest.Tests
{
    public class FunctionTest
    {

        [Fact]
        public void TestSayHelloFunction()
        {
            var context = new TestLambdaContext();
			var functions = new TestFunction();
			var response = functions.SayHello(context);
            Assert.Equal("Hello AWS Serverless", response);
        }
    }
}
