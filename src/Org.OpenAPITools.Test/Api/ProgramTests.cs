using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Security.Cryptography;

namespace Org.OpenAPITools.Test.Api
{
    public class ProgramTests(ITestOutputHelper output) : IDisposable
    {

        private readonly ITestOutputHelper output = output;

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        [Fact]
        public void Test()
        {
            using StreamReader r = new("C:\\Work\\AndDone_SDKs\\anddone-csharp-sdk-openapi-codegen\\config.json");
            dynamic jsonConfig = JObject.Parse(r.ReadToEnd());
            
            string xApiKey = jsonConfig.xApiKey;
            string xAppKey = jsonConfig.xAppKey;
            float xVersion = jsonConfig.xVersion;
            string origin = jsonConfig.origin;

            string URL = "https://api.uat.anddone.com";
            string json = @"{
                ""additionalDetailsPreference"": ""NoAdditionalDetails"",
                ""amount"": ""1000"",
                ""title"": ""API Explorer Test dotNet 001"",
                ""enablePremiumFinance"": true,
                ""expiresIn"": ""300000"",
                ""intent"": {
                    ""paymentTypes"": [
                    ""CreditCard""
                    ]
                },
                ""invoiceNumber"": ""csharp"",
                ""paymentDescription"": ""paymentdescription"",
                ""saveForFuture"": true,
                ""shortDescription"": ""shortDescriptions""
            }";

            JObject data = JObject.Parse(json);
            PaymentIntentRequest request = JsonConvert.DeserializeObject<PaymentIntentRequest>(data.ToString());

            Configuration config = new()
            {
                BasePath = URL
            };
            var apiInstance = new SecurePaymentIntentApi(config);

            try
            {
                ApiResponse<PaymentIntentResponse> response = apiInstance.SecurePaymentintentsPostWithHttpInfo(
                    xApiKey, xAppKey, xVersion, origin, request);
                output.WriteLine("Response: " + response.RawContent);
            }
            catch (ApiException e)
            {
                output.WriteLine("Error: " + e);
            }
        }
    }
}