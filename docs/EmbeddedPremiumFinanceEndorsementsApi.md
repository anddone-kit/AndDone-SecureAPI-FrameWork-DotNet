# Org.OpenAPITools.Api.EmbeddedPremiumFinanceEndorsementsApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureMerchantsEpfQuotesPolicyPost**](EmbeddedPremiumFinanceEndorsementsApi.md#securemerchantsepfquotespolicypost) | **POST** /secure/merchants/epf/quotes/policy | This API will do return a quote for an existing policy or new policy for an existing account |

<a id="securemerchantsepfquotespolicypost"></a>
# **SecureMerchantsEpfQuotesPolicyPost**
> PFEndorsementResponse SecureMerchantsEpfQuotesPolicyPost (string xApiKey, string xAppKey, string origin, string xVersion, PFEndorsementRequest? endorsementRequest = null)

This API will do return a quote for an existing policy or new policy for an existing account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureMerchantsEpfQuotesPolicyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: Origin
            config.AddApiKey("Origin", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Origin", "Bearer");
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new EmbeddedPremiumFinanceEndorsementsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var endorsementRequest = new PFEndorsementRequest?(); // PFEndorsementRequest? | PF Endorsement Request details (optional) 

            try
            {
                // This API will do return a quote for an existing policy or new policy for an existing account
                PFEndorsementResponse result = apiInstance.SecureMerchantsEpfQuotesPolicyPost(xApiKey, xAppKey, origin, xVersion, endorsementRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbeddedPremiumFinanceEndorsementsApi.SecureMerchantsEpfQuotesPolicyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureMerchantsEpfQuotesPolicyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will do return a quote for an existing policy or new policy for an existing account
    ApiResponse<PFEndorsementResponse> response = apiInstance.SecureMerchantsEpfQuotesPolicyPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, endorsementRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbeddedPremiumFinanceEndorsementsApi.SecureMerchantsEpfQuotesPolicyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **xVersion** | **string** | x-version |  |
| **endorsementRequest** | [**PFEndorsementRequest?**](PFEndorsementRequest?.md) | PF Endorsement Request details | [optional]  |

### Return type

[**PFEndorsementResponse**](PFEndorsementResponse.md)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

