# Org.OpenAPITools.Api.SecurePaymentIntentApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureEpfUpdateintentPut**](SecurePaymentIntentApi.md#secureepfupdateintentput) | **PUT** /secure/epf/updateintent | This API is use update the amount of payment intent. |
| [**SecurePaymentintentsExpirationsPost**](SecurePaymentIntentApi.md#securepaymentintentsexpirationspost) | **POST** /secure/paymentintents/expirations | This API expires the payment Intent or link. |
| [**SecurePaymentintentsPost**](SecurePaymentIntentApi.md#securepaymentintentspost) | **POST** /secure/paymentintents | This API is use to create Secure payment Intent. |

<a id="secureepfupdateintentput"></a>
# **SecureEpfUpdateintentPut**
> void SecureEpfUpdateintentPut (string xApiKey, string xAppKey, string xVersion, string origin, UpdateIntentRequest updateIntentRequest)

This API is use update the amount of payment intent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureEpfUpdateintentPutExample
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

            var apiInstance = new SecurePaymentIntentApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = "xVersion_example";  // string | x-version
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var updateIntentRequest = new UpdateIntentRequest(); // UpdateIntentRequest | Update Intent Request

            try
            {
                // This API is use update the amount of payment intent.
                apiInstance.SecureEpfUpdateintentPut(xApiKey, xAppKey, xVersion, origin, updateIntentRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentIntentApi.SecureEpfUpdateintentPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEpfUpdateintentPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is use update the amount of payment intent.
    apiInstance.SecureEpfUpdateintentPutWithHttpInfo(xApiKey, xAppKey, xVersion, origin, updateIntentRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentIntentApi.SecureEpfUpdateintentPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **string** | x-version |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **updateIntentRequest** | [**UpdateIntentRequest**](UpdateIntentRequest.md) | Update Intent Request |  |

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

<a id="securepaymentintentsexpirationspost"></a>
# **SecurePaymentintentsExpirationsPost**
> PaymentIntentExpiresResponse SecurePaymentintentsExpirationsPost (string xApiKey, string xAppKey, string xVersion, string origin, string? id = null)

This API expires the payment Intent or link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentintentsExpirationsPostExample
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

            var apiInstance = new SecurePaymentIntentApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = "xVersion_example";  // string | x-version
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var id = "id_example";  // string? | Payment Intent Id (optional) 

            try
            {
                // This API expires the payment Intent or link.
                PaymentIntentExpiresResponse result = apiInstance.SecurePaymentintentsExpirationsPost(xApiKey, xAppKey, xVersion, origin, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsExpirationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentintentsExpirationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API expires the payment Intent or link.
    ApiResponse<PaymentIntentExpiresResponse> response = apiInstance.SecurePaymentintentsExpirationsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsExpirationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **string** | x-version |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **id** | **string?** | Payment Intent Id | [optional]  |

### Return type

[**PaymentIntentExpiresResponse**](PaymentIntentExpiresResponse.md)

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

<a id="securepaymentintentspost"></a>
# **SecurePaymentintentsPost**
> PaymentIntentResponse SecurePaymentintentsPost (string xApiKey, string xAppKey, string xVersion, string origin, PaymentIntentRequest? paymentIntentRequest = null)

This API is use to create Secure payment Intent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurePaymentintentsPostExample
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

            var apiInstance = new SecurePaymentIntentApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = "xVersion_example";  // string | x-version
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var paymentIntentRequest = new PaymentIntentRequest?(); // PaymentIntentRequest? | Payment Intent Request (optional) 

            try
            {
                // This API is use to create Secure payment Intent.
                PaymentIntentResponse result = apiInstance.SecurePaymentintentsPost(xApiKey, xAppKey, xVersion, origin, paymentIntentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentintentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is use to create Secure payment Intent.
    ApiResponse<PaymentIntentResponse> response = apiInstance.SecurePaymentintentsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentIntentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **string** | x-version |  |
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **paymentIntentRequest** | [**PaymentIntentRequest?**](PaymentIntentRequest?.md) | Payment Intent Request | [optional]  |

### Return type

[**PaymentIntentResponse**](PaymentIntentResponse.md)

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

