# Org.OpenAPITools.Api.SecurePaymentBatchingApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureBatchesDetailsPost**](SecurePaymentBatchingApi.md#securebatchesdetailspost) | **POST** /secure/batches/details | This API is used for getting Secure Payment Batch Details |
| [**SecureBatchesExecutePost**](SecurePaymentBatchingApi.md#securebatchesexecutepost) | **POST** /secure/batches/execute | This API execute on-demand batch transaction. |
| [**SecureBatchesPost**](SecurePaymentBatchingApi.md#securebatchespost) | **POST** /secure/batches | This API is used for getting Secure Payment Batches |
| [**SecureBatchesTimelinesPost**](SecurePaymentBatchingApi.md#securebatchestimelinespost) | **POST** /secure/batches/timelines | This API will returns batch timeline. |
| [**SecureBatchesTransactionsCancelPost**](SecurePaymentBatchingApi.md#securebatchestransactionscancelpost) | **POST** /secure/batches/transactions/cancel | This API cancels transactions from an active batch. |

<a id="securebatchesdetailspost"></a>
# **SecureBatchesDetailsPost**
> List&lt;PaymentBatchDetailsResponse&gt; SecureBatchesDetailsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecurePaymentBatchDetailsRequest securePaymentBatchDetailsRequest)

This API is used for getting Secure Payment Batch Details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureBatchesDetailsPostExample
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

            var apiInstance = new SecurePaymentBatchingApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var securePaymentBatchDetailsRequest = new SecurePaymentBatchDetailsRequest(); // SecurePaymentBatchDetailsRequest | Secure Payment Batch Details Request

            try
            {
                // This API is used for getting Secure Payment Batch Details
                List<PaymentBatchDetailsResponse> result = apiInstance.SecureBatchesDetailsPost(xApiKey, xAppKey, xVersion, origin, securePaymentBatchDetailsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureBatchesDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for getting Secure Payment Batch Details
    ApiResponse<List<PaymentBatchDetailsResponse>> response = apiInstance.SecureBatchesDetailsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, securePaymentBatchDetailsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesDetailsPostWithHttpInfo: " + e.Message);
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
| **securePaymentBatchDetailsRequest** | [**SecurePaymentBatchDetailsRequest**](SecurePaymentBatchDetailsRequest.md) | Secure Payment Batch Details Request |  |

### Return type

[**List&lt;PaymentBatchDetailsResponse&gt;**](PaymentBatchDetailsResponse.md)

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

<a id="securebatchesexecutepost"></a>
# **SecureBatchesExecutePost**
> void SecureBatchesExecutePost (string xApiKey, string xAppKey, float xVersion, string origin, SecureBatchExecuteRequest secureBatchExecuteRequest)

This API execute on-demand batch transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureBatchesExecutePostExample
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

            var apiInstance = new SecurePaymentBatchingApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureBatchExecuteRequest = new SecureBatchExecuteRequest(); // SecureBatchExecuteRequest | Payment Batch Execution Request

            try
            {
                // This API execute on-demand batch transaction.
                apiInstance.SecureBatchesExecutePost(xApiKey, xAppKey, xVersion, origin, secureBatchExecuteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesExecutePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureBatchesExecutePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API execute on-demand batch transaction.
    apiInstance.SecureBatchesExecutePostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureBatchExecuteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesExecutePostWithHttpInfo: " + e.Message);
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
| **secureBatchExecuteRequest** | [**SecureBatchExecuteRequest**](SecureBatchExecuteRequest.md) | Payment Batch Execution Request |  |

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

<a id="securebatchespost"></a>
# **SecureBatchesPost**
> PaymentBatchResponse SecureBatchesPost (string xApiKey, string xAppKey, float xVersion, string origin, float? startRow = null, float? pageSize = null, string? sortField = null, bool? asc = null)

This API is used for getting Secure Payment Batches

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureBatchesPostExample
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

            var apiInstance = new SecurePaymentBatchingApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var startRow = 8.14D;  // float? | Set StartRow (optional) 
            var pageSize = 8.14D;  // float? | Set PageSize (optional) 
            var sortField = "sortField_example";  // string? | Set SortField (optional) 
            var asc = true;  // bool? | Set Asc (optional) 

            try
            {
                // This API is used for getting Secure Payment Batches
                PaymentBatchResponse result = apiInstance.SecureBatchesPost(xApiKey, xAppKey, xVersion, origin, startRow, pageSize, sortField, asc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureBatchesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for getting Secure Payment Batches
    ApiResponse<PaymentBatchResponse> response = apiInstance.SecureBatchesPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, startRow, pageSize, sortField, asc);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesPostWithHttpInfo: " + e.Message);
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
| **startRow** | **float?** | Set StartRow | [optional]  |
| **pageSize** | **float?** | Set PageSize | [optional]  |
| **sortField** | **string?** | Set SortField | [optional]  |
| **asc** | **bool?** | Set Asc | [optional]  |

### Return type

[**PaymentBatchResponse**](PaymentBatchResponse.md)

### Authorization

[x-api-key](../README.md#x-api-key), [x-app-key](../README.md#x-app-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="securebatchestimelinespost"></a>
# **SecureBatchesTimelinesPost**
> List&lt;PaymentBatchEventLogResponse&gt; SecureBatchesTimelinesPost (string xApiKey, string xAppKey, float xVersion, string origin, SecurePaymentBatchDetailsRequest securePaymentBatchDetailsRequest)

This API will returns batch timeline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureBatchesTimelinesPostExample
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

            var apiInstance = new SecurePaymentBatchingApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var securePaymentBatchDetailsRequest = new SecurePaymentBatchDetailsRequest(); // SecurePaymentBatchDetailsRequest | Payment Batch Timeline Request

            try
            {
                // This API will returns batch timeline.
                List<PaymentBatchEventLogResponse> result = apiInstance.SecureBatchesTimelinesPost(xApiKey, xAppKey, xVersion, origin, securePaymentBatchDetailsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesTimelinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureBatchesTimelinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API will returns batch timeline.
    ApiResponse<List<PaymentBatchEventLogResponse>> response = apiInstance.SecureBatchesTimelinesPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, securePaymentBatchDetailsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesTimelinesPostWithHttpInfo: " + e.Message);
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
| **securePaymentBatchDetailsRequest** | [**SecurePaymentBatchDetailsRequest**](SecurePaymentBatchDetailsRequest.md) | Payment Batch Timeline Request |  |

### Return type

[**List&lt;PaymentBatchEventLogResponse&gt;**](PaymentBatchEventLogResponse.md)

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

<a id="securebatchestransactionscancelpost"></a>
# **SecureBatchesTransactionsCancelPost**
> void SecureBatchesTransactionsCancelPost (string xApiKey, string xAppKey, float xVersion, string origin, PaymentBatchCancellationRequest paymentBatchCancellationRequest)

This API cancels transactions from an active batch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureBatchesTransactionsCancelPostExample
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

            var apiInstance = new SecurePaymentBatchingApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentBatchCancellationRequest = new PaymentBatchCancellationRequest(); // PaymentBatchCancellationRequest | Payment Batch Cancellation Request

            try
            {
                // This API cancels transactions from an active batch.
                apiInstance.SecureBatchesTransactionsCancelPost(xApiKey, xAppKey, xVersion, origin, paymentBatchCancellationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesTransactionsCancelPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureBatchesTransactionsCancelPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API cancels transactions from an active batch.
    apiInstance.SecureBatchesTransactionsCancelPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentBatchCancellationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurePaymentBatchingApi.SecureBatchesTransactionsCancelPostWithHttpInfo: " + e.Message);
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
| **paymentBatchCancellationRequest** | [**PaymentBatchCancellationRequest**](PaymentBatchCancellationRequest.md) | Payment Batch Cancellation Request |  |

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

