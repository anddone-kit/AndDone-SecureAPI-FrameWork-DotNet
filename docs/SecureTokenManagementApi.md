# Org.OpenAPITools.Api.SecureTokenManagementApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureTokensActivationsDelete**](SecureTokenManagementApi.md#securetokensactivationsdelete) | **DELETE** /secure/tokens/activations | This API is used for deactivating merchant token securely |
| [**SecureTokensDetailsPost**](SecureTokenManagementApi.md#securetokensdetailspost) | **POST** /secure/tokens/details | This API is used for getting details of Merchant Token by Token link. |

<a id="securetokensactivationsdelete"></a>
# **SecureTokensActivationsDelete**
> void SecureTokensActivationsDelete (string xApiKey, string xAppKey, float xVersion, string origin, TokenRequest tokenRequest)

This API is used for deactivating merchant token securely

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokensActivationsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureTokenManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var tokenRequest = new TokenRequest(); // TokenRequest | secure merchant token request

            try
            {
                // This API is used for deactivating merchant token securely
                apiInstance.SecureTokensActivationsDelete(xApiKey, xAppKey, xVersion, origin, tokenRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenManagementApi.SecureTokensActivationsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokensActivationsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for deactivating merchant token securely
    apiInstance.SecureTokensActivationsDeleteWithHttpInfo(xApiKey, xAppKey, xVersion, origin, tokenRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenManagementApi.SecureTokensActivationsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **tokenRequest** | [**TokenRequest**](TokenRequest.md) | secure merchant token request |  |

### Return type

void (empty response body)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokensdetailspost"></a>
# **SecureTokensDetailsPost**
> SecureMerchantTokenShortResponse SecureTokensDetailsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureTokenLinkRequest secureTokenLinkRequest)

This API is used for getting details of Merchant Token by Token link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokensDetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            // Configure API key authorization: x-api-key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: x-app-key
            config.AddApiKey("x-app-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-app-key", "Bearer");

            var apiInstance = new SecureTokenManagementApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureTokenLinkRequest = new SecureTokenLinkRequest(); // SecureTokenLinkRequest | Secure Token Link Id Request

            try
            {
                // This API is used for getting details of Merchant Token by Token link.
                SecureMerchantTokenShortResponse result = apiInstance.SecureTokensDetailsPost(xApiKey, xAppKey, xVersion, origin, secureTokenLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenManagementApi.SecureTokensDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokensDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for getting details of Merchant Token by Token link.
    ApiResponse<SecureMerchantTokenShortResponse> response = apiInstance.SecureTokensDetailsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureTokenLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenManagementApi.SecureTokensDetailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureTokenLinkRequest** | [**SecureTokenLinkRequest**](SecureTokenLinkRequest.md) | Secure Token Link Id Request |  |

### Return type

[**SecureMerchantTokenShortResponse**](SecureMerchantTokenShortResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

