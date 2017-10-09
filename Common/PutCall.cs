using System;
using IO.Swagger.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Common
{
    public class PutCall
    {
		public string PutHelper()
		{
			InitilizeAzureCred();

			string exampleJson = "{\"name\":\"Intel\",\"swaggerSpecURI\":\"foo\"}";

			var example = exampleJson != null ? JsonConvert.DeserializeObject<ResourceProvider>(exampleJson) : default(ResourceProvider);
			
			return JsonConvert.SerializeObject(example);
		}

		private void InitilizeAzureCred()
		{
			var tenantId = Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
			var clientId = Environment.GetEnvironmentVariable("AZURE_CLIENT_ID");
			var secret = Environment.GetEnvironmentVariable("AZURE_SECRET");
			var subscriptionId = Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID");
		}
    }
}
