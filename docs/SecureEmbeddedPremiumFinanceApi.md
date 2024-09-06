# Org.OpenAPITools.Api.SecureEmbeddedPremiumFinanceApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureMerchantsEpfQuotesPolicyPut**](SecureEmbeddedPremiumFinanceApi.md#securemerchantsepfquotespolicyput) | **PUT** /secure/merchants/epf/quotes/policy | This API is will update the policy number |
| [**SecureTokensActivationsPost**](SecureEmbeddedPremiumFinanceApi.md#securetokensactivationspost) | **POST** /secure/tokens/activations | This API will return quotes created againsts a payment intent. |

<a id="securemerchantsepfquotespolicyput"></a>
# **SecureMerchantsEpfQuotesPolicyPut**
> void SecureMerchantsEpfQuotesPolicyPut (string xApiKey, string xAppKey, string origin, string xVersion, string parentId, PFPolicyUpdateRequestDTO policyUpdateRequest)

This API is will update the policy number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureMerchantsEpfQuotesPolicyPutExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var parentId = "parentId_example";  // string | Merchant identifier
            var policyUpdateRequest = new PFPolicyUpdateRequestDTO(); // PFPolicyUpdateRequestDTO | PFPolicyUpdateRequest DTO

            try
            {
                // This API is will update the policy number
                apiInstance.SecureMerchantsEpfQuotesPolicyPut(xApiKey, xAppKey, origin, xVersion, parentId, policyUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureMerchantsEpfQuotesPolicyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureMerchantsEpfQuotesPolicyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is will update the policy number
    apiInstance.SecureMerchantsEpfQuotesPolicyPutWithHttpInfo(xApiKey, xAppKey, origin, xVersion, parentId, policyUpdateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureMerchantsEpfQuotesPolicyPutWithHttpInfo: " + e.Message);
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
| **parentId** | **string** | Merchant identifier |  |
| **policyUpdateRequest** | [**PFPolicyUpdateRequestDTO**](PFPolicyUpdateRequestDTO.md) | PFPolicyUpdateRequest DTO |  |

### Return type

void (empty response body)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokensactivationspost"></a>
# **SecureTokensActivationsPost**
> Object SecureTokensActivationsPost (string xApiKey, string xAppKey, string origin, string xVersion, GetQuoteRequest quoteRequest)

This API will return quotes created againsts a payment intent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokensActivationsPostExample
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

            var apiInstance = new SecureEmbeddedPremiumFinanceApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var quoteRequest = new GetQuoteRequest(); // GetQuoteRequest | Signature Request details

            try
            {
                // This API will return quotes created againsts a payment intent.
                Object result = apiInstance.SecureTokensActivationsPost(xApiKey, xAppKey, origin, xVersion, quoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureTokensActivationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokensActivationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will return quotes created againsts a payment intent.
    ApiResponse<Object> response = apiInstance.SecureTokensActivationsPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, quoteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureEmbeddedPremiumFinanceApi.SecureTokensActivationsPostWithHttpInfo: " + e.Message);
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
| **quoteRequest** | [**GetQuoteRequest**](GetQuoteRequest.md) | Signature Request details |  |

### Return type

**Object**

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

