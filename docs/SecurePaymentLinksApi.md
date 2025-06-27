# Org.OpenAPITools.Api.SecurePaymentLinksApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurePaymentlinksDetailsPost**](SecurePaymentLinksApi.md#securepaymentlinksdetailspost) | **POST** /secure/paymentlinks/details | This API is used for getting Payment Links by PaymentLink ID |
| [**SecurePaymentlinksExpirationsPost**](SecurePaymentLinksApi.md#securepaymentlinksexpirationspost) | **POST** /secure/paymentlinks/expirations | This API is used for to set expired payment link |
| [**SecurePaymentlinksIdPut**](SecurePaymentLinksApi.md#securepaymentlinksidput) | **PUT** /secure/paymentlinks/{id} | This API is used to update Payment Links |
| [**SecurePaymentlinksPost**](SecurePaymentLinksApi.md#securepaymentlinkspost) | **POST** /secure/paymentlinks | This API is used to create Payment Links |

<a id="securepaymentlinksdetailspost"></a>
# **SecurePaymentlinksDetailsPost**
> PaymentLinkResponse SecurePaymentlinksDetailsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecurePaymentLinkRequest securePaymentLinkRequest)

This API is used for getting Payment Links by PaymentLink ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentlinksDetailsPostExample
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

            var apiInstance = new SecurePaymentLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var securePaymentLinkRequest = new SecurePaymentLinkRequest(); // SecurePaymentLinkRequest | Secure Payment Link Request

            try
            {
                // This API is used for getting Payment Links by PaymentLink ID
                PaymentLinkResponse result = apiInstance.SecurePaymentlinksDetailsPost(xApiKey, xAppKey, xVersion, origin, securePaymentLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentlinksDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for getting Payment Links by PaymentLink ID
    ApiResponse<PaymentLinkResponse> response = apiInstance.SecurePaymentlinksDetailsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, securePaymentLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksDetailsPostWithHttpInfo: " + e.Message);
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
| **securePaymentLinkRequest** | [**SecurePaymentLinkRequest**](SecurePaymentLinkRequest.md) | Secure Payment Link Request |  |

### Return type

[**PaymentLinkResponse**](PaymentLinkResponse.md)

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

<a id="securepaymentlinksexpirationspost"></a>
# **SecurePaymentlinksExpirationsPost**
> PaymentLinkExpiresResponse SecurePaymentlinksExpirationsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecurePaymentLinkRequest? securePaymentLinkRequest = null)

This API is used for to set expired payment link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentlinksExpirationsPostExample
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

            var apiInstance = new SecurePaymentLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var securePaymentLinkRequest = new SecurePaymentLinkRequest?(); // SecurePaymentLinkRequest? | Secure Payment Link Request (optional) 

            try
            {
                // This API is used for to set expired payment link
                PaymentLinkExpiresResponse result = apiInstance.SecurePaymentlinksExpirationsPost(xApiKey, xAppKey, xVersion, origin, securePaymentLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksExpirationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentlinksExpirationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for to set expired payment link
    ApiResponse<PaymentLinkExpiresResponse> response = apiInstance.SecurePaymentlinksExpirationsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, securePaymentLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksExpirationsPostWithHttpInfo: " + e.Message);
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
| **securePaymentLinkRequest** | [**SecurePaymentLinkRequest?**](SecurePaymentLinkRequest?.md) | Secure Payment Link Request | [optional]  |

### Return type

[**PaymentLinkExpiresResponse**](PaymentLinkExpiresResponse.md)

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

<a id="securepaymentlinksidput"></a>
# **SecurePaymentlinksIdPut**
> PaymentLinkResponse SecurePaymentlinksIdPut (string xApiKey, string xAppKey, float xVersion, string origin, string id, SecureUpdatePaymentLinkRequest secureUpdatePaymentLinkRequest)

This API is used to update Payment Links

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentlinksIdPutExample
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

            var apiInstance = new SecurePaymentLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var id = "id_example";  // string | PaymentLink identifier
            var secureUpdatePaymentLinkRequest = new SecureUpdatePaymentLinkRequest(); // SecureUpdatePaymentLinkRequest | Payment Link Request

            try
            {
                // This API is used to update Payment Links
                PaymentLinkResponse result = apiInstance.SecurePaymentlinksIdPut(xApiKey, xAppKey, xVersion, origin, id, secureUpdatePaymentLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentlinksIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used to update Payment Links
    ApiResponse<PaymentLinkResponse> response = apiInstance.SecurePaymentlinksIdPutWithHttpInfo(xApiKey, xAppKey, xVersion, origin, id, secureUpdatePaymentLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksIdPutWithHttpInfo: " + e.Message);
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
| **id** | **string** | PaymentLink identifier |  |
| **secureUpdatePaymentLinkRequest** | [**SecureUpdatePaymentLinkRequest**](SecureUpdatePaymentLinkRequest.md) | Payment Link Request |  |

### Return type

[**PaymentLinkResponse**](PaymentLinkResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securepaymentlinkspost"></a>
# **SecurePaymentlinksPost**
> PaymentLinkResponse SecurePaymentlinksPost (string xApiKey, string xAppKey, float xVersion, string origin, PaymentLinkRequest paymentLinkRequest)

This API is used to create Payment Links

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentlinksPostExample
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

            var apiInstance = new SecurePaymentLinksApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentLinkRequest = new PaymentLinkRequest(); // PaymentLinkRequest | Payment Link Request

            try
            {
                // This API is used to create Payment Links
                PaymentLinkResponse result = apiInstance.SecurePaymentlinksPost(xApiKey, xAppKey, xVersion, origin, paymentLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentlinksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used to create Payment Links
    ApiResponse<PaymentLinkResponse> response = apiInstance.SecurePaymentlinksPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentLinksApi.SecurePaymentlinksPostWithHttpInfo: " + e.Message);
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
| **paymentLinkRequest** | [**PaymentLinkRequest**](PaymentLinkRequest.md) | Payment Link Request |  |

### Return type

[**PaymentLinkResponse**](PaymentLinkResponse.md)

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

