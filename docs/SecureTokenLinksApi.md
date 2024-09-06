# Org.OpenAPITools.Api.SecureTokenLinksApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureTokenlinksDetailsPost**](SecureTokenLinksApi.md#securetokenlinksdetailspost) | **POST** /secure/tokenlinks/details | This API is used for getting Token Links by TokenLink ID |
| [**SecureTokenlinksExpirationsPost**](SecureTokenLinksApi.md#securetokenlinksexpirationspost) | **POST** /secure/tokenlinks/expirations | This API expires the token link. |
| [**SecureTokenlinksListPost**](SecureTokenLinksApi.md#securetokenlinkslistpost) | **POST** /secure/tokenlinks/list | This API is used for getting all Token Links for Merchant |
| [**SecureTokenlinksPost**](SecureTokenLinksApi.md#securetokenlinkspost) | **POST** /secure/tokenlinks | This API is use to create Secure Token Links |
| [**SecureTokenlinksPut**](SecureTokenLinksApi.md#securetokenlinksput) | **PUT** /secure/tokenlinks | This API will update the expireIn and paymentType of Token Link. |
| [**SecureTokensDetailsPost**](SecureTokenLinksApi.md#securetokensdetailspost) | **POST** /secure/tokens/details | This API is used for getting details of Token Link |

<a id="securetokenlinksdetailspost"></a>
# **SecureTokenlinksDetailsPost**
> TokenLinkByIdResponse SecureTokenlinksDetailsPost (string xApiKey, string xAppKey, string origin, string xVersion, SecureTokenLinkIdRequest secureTokenLinkIdRequest)

This API is used for getting Token Links by TokenLink ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokenlinksDetailsPostExample
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

            var apiInstance = new SecureTokenLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var secureTokenLinkIdRequest = new SecureTokenLinkIdRequest(); // SecureTokenLinkIdRequest | Secure Token Link Id Request

            try
            {
                // This API is used for getting Token Links by TokenLink ID
                TokenLinkByIdResponse result = apiInstance.SecureTokenlinksDetailsPost(xApiKey, xAppKey, origin, xVersion, secureTokenLinkIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokenlinksDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for getting Token Links by TokenLink ID
    ApiResponse<TokenLinkByIdResponse> response = apiInstance.SecureTokenlinksDetailsPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, secureTokenLinkIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksDetailsPostWithHttpInfo: " + e.Message);
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
| **secureTokenLinkIdRequest** | [**SecureTokenLinkIdRequest**](SecureTokenLinkIdRequest.md) | Secure Token Link Id Request |  |

### Return type

[**TokenLinkByIdResponse**](TokenLinkByIdResponse.md)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokenlinksexpirationspost"></a>
# **SecureTokenlinksExpirationsPost**
> Object SecureTokenlinksExpirationsPost (string xApiKey, string xAppKey, string origin, string xVersion, SecureTokenLinkIdRequest secureTokenLinkIdRequest)

This API expires the token link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokenlinksExpirationsPostExample
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

            var apiInstance = new SecureTokenLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var secureTokenLinkIdRequest = new SecureTokenLinkIdRequest(); // SecureTokenLinkIdRequest | Secure Token Link Id Request

            try
            {
                // This API expires the token link.
                Object result = apiInstance.SecureTokenlinksExpirationsPost(xApiKey, xAppKey, origin, xVersion, secureTokenLinkIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksExpirationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokenlinksExpirationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API expires the token link.
    ApiResponse<Object> response = apiInstance.SecureTokenlinksExpirationsPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, secureTokenLinkIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksExpirationsPostWithHttpInfo: " + e.Message);
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
| **secureTokenLinkIdRequest** | [**SecureTokenLinkIdRequest**](SecureTokenLinkIdRequest.md) | Secure Token Link Id Request |  |

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokenlinkslistpost"></a>
# **SecureTokenlinksListPost**
> TokenLinkResponse SecureTokenlinksListPost (string xApiKey, string xAppKey, string origin, string xVersion, Object? tokenLinkSearchCriteria = null, Object? pageInfo = null)

This API is used for getting all Token Links for Merchant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokenlinksListPostExample
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

            var apiInstance = new SecureTokenLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var tokenLinkSearchCriteria = new Object?(); // Object? | Token Link search criteria (optional) 
            var pageInfo = new Object?(); // Object? | Set Page Info (optional) 

            try
            {
                // This API is used for getting all Token Links for Merchant
                TokenLinkResponse result = apiInstance.SecureTokenlinksListPost(xApiKey, xAppKey, origin, xVersion, tokenLinkSearchCriteria, pageInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksListPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokenlinksListPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for getting all Token Links for Merchant
    ApiResponse<TokenLinkResponse> response = apiInstance.SecureTokenlinksListPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, tokenLinkSearchCriteria, pageInfo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksListPostWithHttpInfo: " + e.Message);
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
| **tokenLinkSearchCriteria** | [**Object?**](Object?.md) | Token Link search criteria | [optional]  |
| **pageInfo** | [**Object?**](Object?.md) | Set Page Info | [optional]  |

### Return type

[**TokenLinkResponse**](TokenLinkResponse.md)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokenlinkspost"></a>
# **SecureTokenlinksPost**
> TokenLinkResponse SecureTokenlinksPost (string xApiKey, string xAppKey, string origin, string xVersion, SecureTokenLinkRequest secureTokenLinkRequest)

This API is use to create Secure Token Links

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokenlinksPostExample
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

            var apiInstance = new SecureTokenLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var secureTokenLinkRequest = new SecureTokenLinkRequest(); // SecureTokenLinkRequest | Secure Token Link Request

            try
            {
                // This API is use to create Secure Token Links
                TokenLinkResponse result = apiInstance.SecureTokenlinksPost(xApiKey, xAppKey, origin, xVersion, secureTokenLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokenlinksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is use to create Secure Token Links
    ApiResponse<TokenLinkResponse> response = apiInstance.SecureTokenlinksPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, secureTokenLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksPostWithHttpInfo: " + e.Message);
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
| **secureTokenLinkRequest** | [**SecureTokenLinkRequest**](SecureTokenLinkRequest.md) | Secure Token Link Request |  |

### Return type

[**TokenLinkResponse**](TokenLinkResponse.md)

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

<a id="securetokenlinksput"></a>
# **SecureTokenlinksPut**
> void SecureTokenlinksPut (string xApiKey, string xAppKey, string origin, string xVersion, SecureTokenLinkUpdateRequest secureTokenLinkUpdateRequest)

This API will update the expireIn and paymentType of Token Link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureTokenlinksPutExample
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

            var apiInstance = new SecureTokenLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var secureTokenLinkUpdateRequest = new SecureTokenLinkUpdateRequest(); // SecureTokenLinkUpdateRequest | Secure Token Link Update Request

            try
            {
                // This API will update the expireIn and paymentType of Token Link.
                apiInstance.SecureTokenlinksPut(xApiKey, xAppKey, origin, xVersion, secureTokenLinkUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureTokenlinksPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will update the expireIn and paymentType of Token Link.
    apiInstance.SecureTokenlinksPutWithHttpInfo(xApiKey, xAppKey, origin, xVersion, secureTokenLinkUpdateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokenlinksPutWithHttpInfo: " + e.Message);
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
| **secureTokenLinkUpdateRequest** | [**SecureTokenLinkUpdateRequest**](SecureTokenLinkUpdateRequest.md) | Secure Token Link Update Request |  |

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

<a id="securetokensdetailspost"></a>
# **SecureTokensDetailsPost**
> MerchantTokenShortResponse SecureTokensDetailsPost (string xApiKey, string xAppKey, string origin, string xVersion, SecureTokenLinkIdRequest secureTokenLinkIdRequest)

This API is used for getting details of Token Link

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

            var apiInstance = new SecureTokenLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var secureTokenLinkIdRequest = new SecureTokenLinkIdRequest(); // SecureTokenLinkIdRequest | Secure Token Link Id Request

            try
            {
                // This API is used for getting details of Token Link
                MerchantTokenShortResponse result = apiInstance.SecureTokensDetailsPost(xApiKey, xAppKey, origin, xVersion, secureTokenLinkIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokensDetailsPost: " + e.Message);
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
    // This API is used for getting details of Token Link
    ApiResponse<MerchantTokenShortResponse> response = apiInstance.SecureTokensDetailsPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, secureTokenLinkIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureTokenLinksApi.SecureTokensDetailsPostWithHttpInfo: " + e.Message);
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
| **secureTokenLinkIdRequest** | [**SecureTokenLinkIdRequest**](SecureTokenLinkIdRequest.md) | Secure Token Link Id Request |  |

### Return type

[**MerchantTokenShortResponse**](MerchantTokenShortResponse.md)

### Authorization

[Origin](../README.md#Origin), [x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **500** | Server Error |  -  |
| **2XX** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

