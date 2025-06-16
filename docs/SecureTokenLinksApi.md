# Org.OpenAPITools.Api.SecureTokenLinksApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureTokenlinksDetailsPost**](SecureTokenLinksApi.md#securetokenlinksdetailspost) | **POST** /secure/tokenlinks/details | This API is used for getting Token Links by TokenLink ID |
| [**SecureTokenlinksExpirationsPost**](SecureTokenLinksApi.md#securetokenlinksexpirationspost) | **POST** /secure/tokenlinks/expirations | This API expires the token link. |
| [**SecureTokenlinksListPost**](SecureTokenLinksApi.md#securetokenlinkslistpost) | **POST** /secure/tokenlinks/list | This API is used for getting all Token Links for Merchant |
| [**SecureTokenlinksPost**](SecureTokenLinksApi.md#securetokenlinkspost) | **POST** /secure/tokenlinks | This API is use to create Secure Token Links |
| [**SecureTokenlinksPut**](SecureTokenLinksApi.md#securetokenlinksput) | **PUT** /secure/tokenlinks | This API will update the expireIn and paymentType of Token Link. |

<a id="securetokenlinksdetailspost"></a>
# **SecureTokenlinksDetailsPost**
> SecureTokenLinkByIdResponse SecureTokenlinksDetailsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureTokenLinkRequest secureTokenLinkRequest)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureTokenLinkRequest = new SecureTokenLinkRequest(); // SecureTokenLinkRequest | Secure Token Link Id Request

            try
            {
                // This API is used for getting Token Links by TokenLink ID
                SecureTokenLinkByIdResponse result = apiInstance.SecureTokenlinksDetailsPost(xApiKey, xAppKey, xVersion, origin, secureTokenLinkRequest);
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
    ApiResponse<SecureTokenLinkByIdResponse> response = apiInstance.SecureTokenlinksDetailsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureTokenLinkRequest);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureTokenLinkRequest** | [**SecureTokenLinkRequest**](SecureTokenLinkRequest.md) | Secure Token Link Id Request |  |

### Return type

[**SecureTokenLinkByIdResponse**](SecureTokenLinkByIdResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokenlinksexpirationspost"></a>
# **SecureTokenlinksExpirationsPost**
> SecureTokenLinkExpiredResponse SecureTokenlinksExpirationsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureTokenLinkRequest secureTokenLinkRequest)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureTokenLinkRequest = new SecureTokenLinkRequest(); // SecureTokenLinkRequest | Secure Token Link Id Request

            try
            {
                // This API expires the token link.
                SecureTokenLinkExpiredResponse result = apiInstance.SecureTokenlinksExpirationsPost(xApiKey, xAppKey, xVersion, origin, secureTokenLinkRequest);
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
    ApiResponse<SecureTokenLinkExpiredResponse> response = apiInstance.SecureTokenlinksExpirationsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureTokenLinkRequest);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureTokenLinkRequest** | [**SecureTokenLinkRequest**](SecureTokenLinkRequest.md) | Secure Token Link Id Request |  |

### Return type

[**SecureTokenLinkExpiredResponse**](SecureTokenLinkExpiredResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokenlinkslistpost"></a>
# **SecureTokenlinksListPost**
> TokenLinkResponse SecureTokenlinksListPost (string xApiKey, string xAppKey, float xVersion, string origin, string? email = null, string? status = null, string? phone = null, string? statuses = null, string? title = null, string? paymentDescription = null, string? invoiceNumber = null, string? expiryDate = null, string? fromExpiryDate = null, string? freeTextSearch = null, string? tokenLinkId = null, string? toExpiryDate = null, string? fromDate = null, string? toDate = null, float? startRow = null, float? pageSize = null, string? sortField = null, bool? asc = null)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var email = "email_example";  // string? | email (optional) 
            var status = "NA";  // string? | status (optional) 
            var phone = "phone_example";  // string? | phone (optional) 
            var statuses = "statuses_example";  // string? | statuses (optional) 
            var title = "title_example";  // string? | title (optional) 
            var paymentDescription = "paymentDescription_example";  // string? | paymentDescription (optional) 
            var invoiceNumber = "invoiceNumber_example";  // string? | invoiceNumber (optional) 
            var expiryDate = "expiryDate_example";  // string? | expiryDate (optional) 
            var fromExpiryDate = "fromExpiryDate_example";  // string? | fromExpiryDate (optional) 
            var freeTextSearch = "freeTextSearch_example";  // string? | freeTextSearch (optional) 
            var tokenLinkId = "tokenLinkId_example";  // string? | tokenLinkId (optional) 
            var toExpiryDate = "toExpiryDate_example";  // string? | toExpiryDate (optional) 
            var fromDate = "fromDate_example";  // string? | fromDate (optional) 
            var toDate = "toDate_example";  // string? | toDate (optional) 
            var startRow = 8.14D;  // float? | Set StartRow (optional) 
            var pageSize = 8.14D;  // float? | Set PageSize (optional) 
            var sortField = "sortField_example";  // string? | Set SortField (optional) 
            var asc = true;  // bool? | Set Asc (optional) 

            try
            {
                // This API is used for getting all Token Links for Merchant
                TokenLinkResponse result = apiInstance.SecureTokenlinksListPost(xApiKey, xAppKey, xVersion, origin, email, status, phone, statuses, title, paymentDescription, invoiceNumber, expiryDate, fromExpiryDate, freeTextSearch, tokenLinkId, toExpiryDate, fromDate, toDate, startRow, pageSize, sortField, asc);
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
    ApiResponse<TokenLinkResponse> response = apiInstance.SecureTokenlinksListPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, email, status, phone, statuses, title, paymentDescription, invoiceNumber, expiryDate, fromExpiryDate, freeTextSearch, tokenLinkId, toExpiryDate, fromDate, toDate, startRow, pageSize, sortField, asc);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **email** | **string?** | email | [optional]  |
| **status** | **string?** | status | [optional]  |
| **phone** | **string?** | phone | [optional]  |
| **statuses** | **string?** | statuses | [optional]  |
| **title** | **string?** | title | [optional]  |
| **paymentDescription** | **string?** | paymentDescription | [optional]  |
| **invoiceNumber** | **string?** | invoiceNumber | [optional]  |
| **expiryDate** | **string?** | expiryDate | [optional]  |
| **fromExpiryDate** | **string?** | fromExpiryDate | [optional]  |
| **freeTextSearch** | **string?** | freeTextSearch | [optional]  |
| **tokenLinkId** | **string?** | tokenLinkId | [optional]  |
| **toExpiryDate** | **string?** | toExpiryDate | [optional]  |
| **fromDate** | **string?** | fromDate | [optional]  |
| **toDate** | **string?** | toDate | [optional]  |
| **startRow** | **float?** | Set StartRow | [optional]  |
| **pageSize** | **float?** | Set PageSize | [optional]  |
| **sortField** | **string?** | Set SortField | [optional]  |
| **asc** | **bool?** | Set Asc | [optional]  |

### Return type

[**TokenLinkResponse**](TokenLinkResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokenlinkspost"></a>
# **SecureTokenlinksPost**
> SecureTokenLinkResponse SecureTokenlinksPost (string xApiKey, string xAppKey, float xVersion, string origin, TokenLinkSecureRequest tokenLinkSecureRequest)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var tokenLinkSecureRequest = new TokenLinkSecureRequest(); // TokenLinkSecureRequest | Secure Token Link Request

            try
            {
                // This API is use to create Secure Token Links
                SecureTokenLinkResponse result = apiInstance.SecureTokenlinksPost(xApiKey, xAppKey, xVersion, origin, tokenLinkSecureRequest);
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
    ApiResponse<SecureTokenLinkResponse> response = apiInstance.SecureTokenlinksPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, tokenLinkSecureRequest);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **tokenLinkSecureRequest** | [**TokenLinkSecureRequest**](TokenLinkSecureRequest.md) | Secure Token Link Request |  |

### Return type

[**SecureTokenLinkResponse**](SecureTokenLinkResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securetokenlinksput"></a>
# **SecureTokenlinksPut**
> void SecureTokenlinksPut (string xApiKey, string xAppKey, float xVersion, string origin, SecureTokenLinkUpdateRequest secureTokenLinkUpdateRequest)

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
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureTokenLinkUpdateRequest = new SecureTokenLinkUpdateRequest(); // SecureTokenLinkUpdateRequest | Secure Token Link Update Request

            try
            {
                // This API will update the expireIn and paymentType of Token Link.
                apiInstance.SecureTokenlinksPut(xApiKey, xAppKey, xVersion, origin, secureTokenLinkUpdateRequest);
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
    apiInstance.SecureTokenlinksPutWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureTokenLinkUpdateRequest);
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
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureTokenLinkUpdateRequest** | [**SecureTokenLinkUpdateRequest**](SecureTokenLinkUpdateRequest.md) | Secure Token Link Update Request |  |

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

