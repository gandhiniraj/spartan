using System;
using IO.Swagger.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Rest.Azure.Authentication;
using System.Linq;
using System.Threading.Tasks;

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

		public async Task<string> InitilizeAzureCred()
		{
			// Create using following az cli
			// az account set --subscription=<id>
			// az ad sp create-for-rbac --role="Contributor" --scopes="/subscriptions/<subscriptionid>"
			var tenantId = Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
			var clientId = Environment.GetEnvironmentVariable("AZURE_CLIENT_ID");
			var secret = Environment.GetEnvironmentVariable("AZURE_SECRET");
			var subscriptionId = Environment.GetEnvironmentVariable("AZURE_SUBSCRIPTION_ID");

			var serviceCreds = await ApplicationTokenProvider.LoginSilentAsync(tenantId, clientId, secret);
			var resourceClient = new ResourceManagementClient(serviceCreds);
			resourceClient.SubscriptionId = subscriptionId;
			var aRG = resourceClient.ResourceGroups.List().First().Name;
			return aRG;
		}
    }
}
