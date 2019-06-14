using System;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Flagscript.CiCdTest
{
    public class TestFunction
    {

        public TestFunction()
        {

        }


        /// <summary>
        /// A Lambda function to respond to HTTP Get methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The list of blogs</returns>
        public string SayHello(ILambdaContext context)
        {

			string env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        
			context.Logger.LogLine($"SayHello Request - {env}\n");

			return $"Hello AWS Serverless - {env}";
        }
    }
}
