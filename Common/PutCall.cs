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
			string exampleJson = @"{  name: 'Intel',  swaggerSpecURI: 'foo'}";

			var example = exampleJson != null ? JsonConvert.DeserializeObject<ResourceProvider>(exampleJson) : default(ResourceProvider);
			
			return JsonConvert.SerializeObject(example);
		}
    }
}
