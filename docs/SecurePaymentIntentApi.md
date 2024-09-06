# Org.OpenAPITools.Api.SecurePaymentIntentApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecurePaymentintentsExpirationsididPost**](SecurePaymentIntentApi.md#securepaymentintentsexpirationsididpost) | **POST** /secure/paymentintents/expirations?id&#x3D;{id} | This API expires the payment Intent or link. |
| [**SecurePaymentintentsPost**](SecurePaymentIntentApi.md#securepaymentintentspost) | **POST** /secure/paymentintents | This API is use to create Secure payment Intent. |
| [**SecurePaymentintentsPut**](SecurePaymentIntentApi.md#securepaymentintentsput) | **PUT** /secure/paymentintents | This API is use update the amount of payment intent. |

<a id="securepaymentintentsexpirationsididpost"></a>
# **SecurePaymentintentsExpirationsididPost**
> PaymentIntentExpiresResponse SecurePaymentintentsExpirationsididPost (string xApiKey, string xAppKey, string origin, string xVersion, string id)

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
    public class SecurePaymentintentsExpirationsididPostExample
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

            var apiInstance = new SecurePaymentIntentApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var id = "id_example";  // string | Payment Intent Id

            try
            {
                // This API expires the payment Intent or link.
                PaymentIntentExpiresResponse result = apiInstance.SecurePaymentintentsExpirationsididPost(xApiKey, xAppKey, origin, xVersion, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsExpirationsididPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentintentsExpirationsididPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API expires the payment Intent or link.
    ApiResponse<PaymentIntentExpiresResponse> response = apiInstance.SecurePaymentintentsExpirationsididPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsExpirationsididPostWithHttpInfo: " + e.Message);
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
| **id** | **string** | Payment Intent Id |  |

### Return type

[**PaymentIntentExpiresResponse**](PaymentIntentExpiresResponse.md)

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

<a id="securepaymentintentspost"></a>
# **SecurePaymentintentsPost**
> PaymentIntentResponse SecurePaymentintentsPost (string xApiKey, string xAppKey, string origin, string xVersion, PaymentIntentRequest paymentIntentRequest)

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

            var apiInstance = new SecurePaymentIntentApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var paymentIntentRequest = new PaymentIntentRequest(); // PaymentIntentRequest | Payment Intent Request

            try
            {
                // This API is use to create Secure payment Intent.
                PaymentIntentResponse result = apiInstance.SecurePaymentintentsPost(xApiKey, xAppKey, origin, xVersion, paymentIntentRequest);
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
    ApiResponse<PaymentIntentResponse> response = apiInstance.SecurePaymentintentsPostWithHttpInfo(xApiKey, xAppKey, origin, xVersion, paymentIntentRequest);
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
| **origin** | **string** | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration |  |
| **xVersion** | **string** | x-version |  |
| **paymentIntentRequest** | [**PaymentIntentRequest**](PaymentIntentRequest.md) | Payment Intent Request |  |

### Return type

[**PaymentIntentResponse**](PaymentIntentResponse.md)

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

<a id="securepaymentintentsput"></a>
# **SecurePaymentintentsPut**
> void SecurePaymentintentsPut (string xApiKey, string xAppKey, string origin, string xVersion, UpdateIntentRequest updateIntentRequest)

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
    public class SecurePaymentintentsPutExample
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

            var apiInstance = new SecurePaymentIntentApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var origin = "origin_example";  // string | an authorization header. Your origin IP address or URL. Must be configured with AndDone Administration
            var xVersion = "xVersion_example";  // string | x-version
            var updateIntentRequest = new UpdateIntentRequest(); // UpdateIntentRequest | Update Intent Request

            try
            {
                // This API is use update the amount of payment intent.
                apiInstance.SecurePaymentintentsPut(xApiKey, xAppKey, origin, xVersion, updateIntentRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecurePaymentintentsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is use update the amount of payment intent.
    apiInstance.SecurePaymentintentsPutWithHttpInfo(xApiKey, xAppKey, origin, xVersion, updateIntentRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentIntentApi.SecurePaymentintentsPutWithHttpInfo: " + e.Message);
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
| **updateIntentRequest** | [**UpdateIntentRequest**](UpdateIntentRequest.md) | Update Intent Request |  |

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

